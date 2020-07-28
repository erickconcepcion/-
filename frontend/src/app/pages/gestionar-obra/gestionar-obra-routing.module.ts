/*
 * Copyright (c) Akveo 2019. All Rights Reserved.
 * Licensed under the Single Application / Multi Application License.
 * See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the 'docs' folder for license information on type of purchased license.
 */

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { GestionarObraComponent } from './gestionar-obra.component';
/* import { Tab1Component, Tab2Component, TabsComponent } from './tabs/tabs.component';
import { AccordionComponent } from './accordion/accordion.component';
import { InfiniteListComponent } from './infinite-list/infinite-list.component';
import { ListComponent } from './list/list.component';
import { StepperComponent } from './stepper/stepper.component'; */
import { SeccionObraComponent } from './seccion-obra/seccion-obra.component';

const routes: Routes = [{
  path: '',
  component: GestionarObraComponent,
  children: [
    {
      path: 'seccion-obra',
      component: SeccionObraComponent,
    },
    {
      path: 'list',
      /* component: ListComponent, */
    },
    {
      path: 'infinite-list',
      /* component: InfiniteListComponent, */
    },
    {
      path: 'accordion',
      /* component: AccordionComponent, */
    },
  ],
}];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class GestionarObraRoutingModule { }

export  const  routedComponents = [
  GestionarObraComponent,
  SeccionObraComponent,
];
