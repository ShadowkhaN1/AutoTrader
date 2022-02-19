import { Routes } from '@angular/router';
import { AddAdvertisementComponent } from './add-advertisement/add-advertisement.component';

export const appRoutes: Routes = [
  {
    path: '',
    loadChildren: () => import('./home/home.module').then((m) => m.HomeModule),
  },
  { path: 'add-advertisement', component: AddAdvertisementComponent },
  // {
  //   path: 'users',
  //   loadChildren: () => import('./users/users.module').then(m => m.UsersModule)
  // },
  // {path: 'users/register', component: RegisterComponent, },
  // {path: 'users/sign-in', component: SignInComponent, },
];
