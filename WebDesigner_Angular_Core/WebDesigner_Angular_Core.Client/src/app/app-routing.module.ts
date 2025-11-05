import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { HomeComponent } from './home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'create', component: HomeComponent },
  { path: 'edit/:id', component: HomeComponent },
  { path: 'preview/:id', component: HomeComponent },
  { path: '**', redirectTo: '' },
];

@NgModule(
  {
    declarations: [
    ],
    imports: [RouterModule.forRoot(routes), HomeComponent],
    exports: [RouterModule]
  })
export class AppRoutingModule { }
