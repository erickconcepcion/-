/*
 * Copyright (c) Akveo 2019. All Rights Reserved.
 * Licensed under the Single Application / Multi Application License.
 * See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the 'docs' folder for license information on type of purchased license.
 */

import { NgModule } from '@angular/core';
import { NbButtonModule, NbCardModule } from '@nebular/theme';

import { ThemeModule } from '../../@theme/theme.module';
import { AyudaRoutingModule } from './ayuda-routing.module';
import { AyudaComponent } from './ayuda.component';
import { VersionComponent } from './version/version.component';
import { SoporteComponent } from './soporte/soporte.component';

@NgModule({
  imports: [
    ThemeModule,
    NbCardModule,
    NbButtonModule,
    AyudaRoutingModule,
  ],
  declarations: [
    AyudaComponent,
    VersionComponent,
    SoporteComponent,
  ],
})
export class AyudaModule { }
