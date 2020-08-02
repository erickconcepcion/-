import { Component, OnInit } from '@angular/core';
import { DefaultEditor } from 'ng2-smart-table';

@Component({
  selector: 'ngx-numeric-smart-editor',
  templateUrl: './numeric-smart-editor.component.html',
  styleUrls: ['./numeric-smart-editor.component.scss'],
})
export class NumericSmartEditorComponent extends DefaultEditor {

  constructor() {
    super();
  }
}
