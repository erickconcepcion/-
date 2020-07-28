/*
 * Copyright (c) Akveo 2019. All Rights Reserved.
 * Licensed under the Single Application / Multi Application License.
 * See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the 'docs' folder for license information on type of purchased license.
 */

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { GestionarUsuarioComponent } from './gestionar-usuario.component';
import { SeccionUsuarioComponent } from './seccion-usuario/seccion-usuario.component';
/* import { TreeGridComponent } from './tree-grid/tree-grid.component'; */

const routes: Routes = [{
  path: '',
  component: GestionarUsuarioComponent,
  children: [
    {
      path: 'seccion-usuario',
      component: SeccionUsuarioComponent,
    },
    {
      path: 'tree-grid',
   /*    component: TreeGridComponent, */
    },
  ],
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class TablesRoutingModule { }

export const routedComponents = [
  GestionarUsuarioComponent,
  SeccionUsuarioComponent,
  /* TreeGridComponent, */
];
