/*
 * Copyright (c) Akveo 2019. All Rights Reserved.
 * Licensed under the Single Application / Multi Application License.
 * See LICENSE_SINGLE_APP / LICENSE_MULTI_APP in the 'docs' folder for license information on type of purchased license.
 */

import { NbMenuItem } from '@nebular/theme';
import { Observable, of } from 'rxjs';
import { Injectable } from '@angular/core';

@Injectable()
export class PagesMenu {

  getMenu(): Observable<NbMenuItem[]> {
    const dashboardMenu: NbMenuItem[] = [
      {
        title: 'GESTIONAR USUARIOS',
        group: true,
      },
      {
        title: 'Gestionar Usuario',
        icon: 'people-outline',
        link: '/pages/gestionar-usuario',
        home: true,
        children: [
          {
            title: 'Seccion Usuario',
            link: '/pages/gestionar-usuario/seccion-usuario',
          },

      /* {
        title: 'Gestionar Usuario',
        icon: 'people-outline',
        link: '/pages/gestionar-usuarios',
        home: true,
        children: [ {
          title: 'seccion-usuario',
          link: '/pages/gestionar-usuarios/seccion-usuario',
        }, */
      ],
      },
      {
        title: 'IoT Dashboard',
        icon: 'home-outline',
        link: '/pages/iot-dashboard',
        children: undefined,
      },
    ];

    const menu: NbMenuItem[] = [
      {
        title: 'GESTIONAR PRESUPUESTOS',
        group: true,
      },
      {
        title: 'Gestionar Obras',
        icon: 'layout-outline',
        children: [
          {
            title: 'Seccion Obra',
            link: '/pages/gestionar-obra/seccion-obra',
          },
          {
            title: 'List',
            link: '/pages/layout/list',
          },
          {
            title: 'Infinite List',
            link: '/pages/layout/infinite-list',
          },
          {
            title: 'Accordion',
            link: '/pages/layout/accordion',
          },
          {
            title: 'Tabs',
            pathMatch: 'prefix',
            link: '/pages/layout/tabs',
          },
        ],
      },
      {
        title: 'Gestionar Rubros',
        icon: 'edit-2-outline',
        children: [
          {
            title: 'Seccion Rubro',
            link: '/pages/gestionar-rubros/seccion-rubro',
          },
          {
            title: 'Form Layouts',
            link: '/pages/forms/layouts',
          },
          {
            title: 'Buttons',
            link: '/pages/forms/buttons',
          },
          {
            title: 'Datepicker',
            link: '/pages/forms/datepicker',
          },
        ],
      },
      {
        title: 'Generar Análisis',
        icon: 'keypad-outline',
        link: '/pages/ui-features',
        children: [
          {
            title: 'Seccion Analisis',
            link: '/pages/gestionar-analisis/seccion-analisis',
          },
          {
            title: 'Grid',
            link: '/pages/ui-features/grid',
          },
          {
            title: 'Icons',
            link: '/pages/ui-features/icons',
          },
          {
            title: 'Typography',
            link: '/pages/ui-features/typography',
          },
          {
            title: 'Animated Searches',
            link: '/pages/ui-features/search-fields',
          },
        ],
      },
      {
        title: 'Inventario',
        icon: 'browser-outline',
        children: [
          {
            title: 'Seccion Inventario',
            link: '/pages/inventario/seccion-inventario',
          },
          {
            title: 'Window',
            link: '/pages/modal-overlays/window',
          },
          {
            title: 'Popover',
            link: '/pages/modal-overlays/popover',
          },
          {
            title: 'Toastr',
            link: '/pages/modal-overlays/toastr',
          },
          {
            title: 'Tooltip',
            link: '/pages/modal-overlays/tooltip',
          },
        ],
      },
      {
        title: 'Extra Components',
        icon: 'message-circle-outline',
        children: [
          {
            title: 'Calendar',
            link: '/pages/extra-components/calendar',
          },
          {
            title: 'Progress Bar',
            link: '/pages/extra-components/progress-bar',
          },
          {
            title: 'Spinner',
            link: '/pages/extra-components/spinner',
          },
          {
            title: 'Alert',
            link: '/pages/extra-components/alert',
          },
          {
            title: 'Calendar Kit',
            link: '/pages/extra-components/calendar-kit',
          },
          {
            title: 'Chat',
            link: '/pages/extra-components/chat',
          },
        ],
      },
      {
        title: 'Gestionar Productos',
        icon: 'map-outline',
        children: [
          {
            title: 'Seccion Producto',
            link: '/pages/gestionar-producto/seccion-producto',
          },
          {
            title: 'Leaflet Maps',
            link: '/pages/maps/leaflet',
          },
          {
            title: 'Bubble Maps',
            link: '/pages/maps/bubble',
          },
          {
            title: 'Search Maps',
            link: '/pages/maps/searchmap',
          },
        ],
      },
      {
        title: 'Ayuda',
        icon: 'pie-chart-outline',
        children: [
          {
            title: 'Version',
            link: '/pages/ayuda/version',
          },
          {
            title: 'Soporte',
            link: '/pages/ayuda/soporte',
          },
          {
            title: 'Charts.js',
            link: '/pages/charts/chartjs',
          },
          {
            title: 'D3',
            link: '/pages/charts/d3',
          },
        ],
      },
      {
        title: 'Editors',
        icon: 'text-outline',
        children: [
          {
            title: 'TinyMCE',
            link: '/pages/editors/tinymce',
          },
          {
            title: 'CKEditor',
            link: '/pages/editors/ckeditor',
          },
        ],
      },
      {
        title: 'Tables & Data',
        icon: 'grid-outline',
        children: [
          {
            title: 'Smart Table',
            link: '/pages/tables/smart-table',
          },
          {
            title: 'Tree Grid',
            link: '/pages/tables/tree-grid',
          },
        ],
      },
      {
        title: 'Miscellaneous',
        icon: 'shuffle-2-outline',
        children: [
          {
            title: '404',
            link: '/pages/miscellaneous/404',
          },
        ],
      },
      {
        title: 'Auth',
        icon: 'lock-outline',
        children: [
          {
            title: 'Login',
            link: '/auth/login',
          },
          {
            title: 'Register',
            link: '/auth/register',
          },
          {
            title: 'Request Password',
            link: '/auth/request-password',
          },
          {
            title: 'Reset Password',
            link: '/auth/reset-password',
          },
        ],
      },
    ];

    return of([...dashboardMenu, ...menu]);
  }
}
