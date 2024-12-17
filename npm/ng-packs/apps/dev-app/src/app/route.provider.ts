import { eLayoutType, RoutesService } from '@abp/ng.core';
import { inject, provideAppInitializer } from '@angular/core';

export const APP_ROUTE_PROVIDER = [
  provideAppInitializer(() => {
    configureRoutes(inject(RoutesService));
  }),
];

function configureRoutes(routesService: RoutesService) {
  routesService.add([
    {
      path: '/',
      name: '::Menu:Home',
      iconClass: 'fas fa-home',
      order: 1,
      layout: eLayoutType.application,
    },
  ]);
}
