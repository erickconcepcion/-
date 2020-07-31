/*
 * Copyright (c) Akveo 2019. All Rights Reserved.
 * Licensed under the Single Application / Multi Application License.
 * See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the 'docs' folder for license information on type of purchased license.
 */

import { Component } from '@angular/core';
import { LocalDataSource } from 'ng2-smart-table';

import { SmartTableData } from '../../../@core/interfaces/common/smart-table';

@Component({
  selector: 'ngx-smart-table',
  templateUrl: './seccion-obra.component.html',
  styleUrls: ['./seccion-obra.component.scss'],
})
export class SeccionObraComponent {

  settings = {
    add: {
      addButtonContent: '<i class="nb-plus"></i>',
      createButtonContent: '<i class="nb-checkmark"></i>',
      cancelButtonContent: '<i class="nb-close"></i>',
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
      Id: {
        title: 'ID',
        type: 'number',
      },
      CodigoObra: {
        title: 'Codigo obra',
        type: 'string',
      },
      NombreObra: {
        title: 'Nombre obra',
        type: 'string',
      },
      FechaCreacion: {
        title: 'Fecha inicio',
        type: 'datetime',
      },
      NombreCliente: {
        title: 'Nombre cliente',
        type: 'string',
      },
      IdPersonaCliente: {
        title: 'Cédula',
        type: 'string',
      },
      NombreOferente: {
        title: 'Nombre oferente',
        type: 'string',
      },
      IdPersonaOferente: {
        title: 'Cédula',
        type: 'string',
      },
      RegistroProfesional: {
        title: 'Registro Profesional',
        type: 'string',
      },
      Direccion: {
        title: 'Direccion',
        type: 'string',
      },
      IdProvincia: {
        title: 'Código Provincia',
        type: 'number',
      },
      IdCiudad: {
        title: 'Código Ciudad',
        type: 'number',
      },
    },
  };

  source: LocalDataSource = new LocalDataSource();

  constructor(private service: SmartTableData) {
    const data = this.service.getData();
    this.source.load(data);
  }

  onDeleteConfirm(event): void {
    if (window.confirm('Esta seguro que desea eliminar este registro?')) {
      event.confirm.resolve();
    } else {
      event.confirm.reject();
    }
  }
}
