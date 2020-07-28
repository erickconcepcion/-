/*
 * Copyright (c) Akveo 2019. All Rights Reserved.
 * Licensed under the Single Application / Multi Application License.
 * See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the 'docs' folder for license information on type of purchased license.
 */

import { RouterModule, Routes } from '@angular/router';
import { NgModule } from '@angular/core';

import { PagesComponent } from './pages.component';
import { DashboardComponent } from './dashboard/dashboard.component';
import { GestionarUsuarioComponent } from './gestionar-usuario/gestionar-usuario.component';
import { NotFoundComponent } from './miscellaneous/not-found/not-found.component';

const routes: Routes = [{
  path: '',
  component: PagesComponent,
  children: [
    {
      path: 'gestionar-usuario',
      component: GestionarUsuarioComponent,
    },
    {
      path: 'iot-dashboard',
      component: DashboardComponent,
    },
    {
      path: 'users',
      loadChildren: () => import('./users/users.module')
        .then(m => m.UsersModule),
    },
    {
      path: 'gestionar-obra',
      loadChildren: () => import('./gestionar-obra/gestionar-obra.module')
        .then(m => m.GestionarObraModule),
    },
    {
      path: 'gestionar-rubros',
      loadChildren: () => import('./gestionar-rubros/gestionar-rubros.module')
        .then(m => m.GestionarRubroModule),
    },
    {
      path: 'gestionar-analisis',
      loadChildren: () => import('./gestionar-analisis/gestionar-analisis.module')
        .then(m => m.GenerarAnalisisModule),
    },
    {
      path: 'inventario',
      loadChildren: () => import('./inventario/inventario.module')
        .then(m => m.InventarioModule),
    },
    {
      path: 'extra-components',
      loadChildren: () => import('./extra-components/extra-components.module')
        .then(m => m.ExtraComponentsModule),
    },
    {
      path: 'gestionar-producto',
      loadChildren: () => import('./gestionar-producto/gestionar-producto.module')
        .then(m => m.GestionarProductoModule),
    },
    {
      path: 'charts',
      loadChildren: () => import('./charts/charts.module')
        .then(m => m.ChartsModule),
    },
    {
      path: 'editors',
      loadChildren: () => import('./editors/editors.module')
        .then(m => m.EditorsModule),
    },
    {
      path: 'tables',
      loadChildren: () => import('./tables/tables.module')
        .then(m => m.TablesModule),
    },
    {
      path: 'miscellaneous',
      loadChildren: () => import('./miscellaneous/miscellaneous.module')
        .then(m => m.MiscellaneousModule),
    },
    {
      path: '',
      redirectTo: 'dashboard',
      pathMatch: 'full',
    },
    {
      path: '**',
      component: NotFoundComponent,
    },
  ],
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class PagesRoutingModule {
}
