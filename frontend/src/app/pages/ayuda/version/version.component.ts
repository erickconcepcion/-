/*
 * Copyright (c) Akveo 2019. All Rights Reserved.
 * Licensed under the Single Application / Multi Application License.
 * See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the 'docs' folder for license information on type of purchased license.
 */

import { NbMenuService } from '@nebular/theme';
import { Component } from '@angular/core';

@Component({
  selector: 'ngx-not-found',
  styleUrls: ['./version.component.scss'],
  templateUrl: './version.component.html',
})
export class VersionComponent {

  constructor(private menuService: NbMenuService) {
  }

  goToHome() {
    this.menuService.navigateHome();
  }
}
