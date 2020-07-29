/*
 * Copyright (c) Akveo 2019. All Rights Reserved.
 * Licensed under the Single Application / Multi Application License.
 * See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the 'docs' folder for license information on type of purchased license.
 */

import { NgModule } from '@angular/core';
import { NbCardModule, NbIconModule, NbInputModule, NbTreeGridModule } from '@nebular/theme';
import { Ng2SmartTableModule } from 'ng2-smart-table';

import { ThemeModule } from '../../@theme/theme.module';
import {MeasureConverterPipe} from '../../@theme/pipes';
import { GestionarProductoRoutingModule, routedComponents } from './gestionar-producto-routing.module';

@NgModule({
  imports: [
    NbCardModule,
    NbTreeGridModule,
    NbIconModule,
    NbInputModule,
    ThemeModule,
    GestionarProductoRoutingModule,
    Ng2SmartTableModule,
  ],
  declarations: [
    ...routedComponents,
   /*  FsIconComponent, */
  ],
  providers: [
    MeasureConverterPipe,
  ],
})
export class GestionarProductoModule { }
