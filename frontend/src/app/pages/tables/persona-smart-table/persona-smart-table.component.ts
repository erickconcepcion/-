import { Component, OnInit } from '@angular/core';
import { GenericApiService } from '../../../@core/backend/common/services/generic-api.service';
import { Persona } from '../../../@core/interfaces/table/persona';
import { LocalDataSource } from 'ng2-smart-table';
import { Observable } from 'rxjs';
import { take } from 'rxjs/operators';
import {
  NgxFilterByNumberComponent,
 } from '../../../@components/custom-smart-table-components/filter-by-number/filter-by-number.component';
import { NumericSmartEditorComponent,
} from '../../../@theme/components/numeric-smart-editor/numeric-smart-editor.component';

@Component({
  selector: 'ngx-persona-smart-table',
  templateUrl: './persona-smart-table.component.html',
  styleUrls: ['./persona-smart-table.component.scss'],
})
export class PersonaSmartTableComponent implements OnInit {

  constructor(private service: GenericApiService) {
    this.service.setController('personas');
  }

  $data: Observable<Persona[]>;

  ngOnInit() {
    this.$data = this.service.getAll();
  }
  settings = {
    add: {
      addButtonContent: '<i class="nb-plus"></i>',
      createButtonContent: '<i class="nb-checkmark"></i>',
      cancelButtonContent: '<i class="nb-close"></i>',
      confirmCreate: true,
    },
    edit: {
      editButtonContent: '<i class="nb-edit"></i>',
      saveButtonContent: '<i class="nb-checkmark"></i>',
      cancelButtonContent: '<i class="nb-close"></i>',
    },
    delete: {
      deleteButtonContent: '<i class="nb-trash"></i>',
      confirmDelete: true,
    },
    columns: {
      id: {
        title: 'Id',
        type: 'number',
        editable: false,
        editor: {
          type: 'custom',
          component: NumericSmartEditorComponent,
        },
      },
      nombre: {
        title: 'Nombre',
        type: 'string',
        editor: {
          type: 'text',
        },
      },
      gustos: {
        title: 'Gustos',
        type: 'string',
        editor: {
          type: 'text',
        },
      },
      comentarios: {
        title: 'Comentario',
        type: 'string',
        editor: {
          type: 'text',
        },
      },
    },
  };

  onCreateConfirm(event) {
    this.service.add(event.newData).pipe(take(1)).subscribe(d => {
      event.newData = d;
      event.confirm.resolve();
    });
  }
  onDeleteConfirm(event): void {
    if (window.confirm('Are you sure you want to delete?')) {
      event.confirm.resolve();
      this.service.delete(event.data.id).pipe(take(1)).subscribe();
    } else {
      event.confirm.reject();
    }
  }

}
