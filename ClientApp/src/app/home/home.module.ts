import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FlexLayoutModule } from '@angular/flex-layout';
import { RouterModule } from '@angular/router';

import { HomeComponent } from './home.component';
import { SearchFormModule } from './../search-form/search-form.module';

@NgModule({
  declarations: [HomeComponent],
  imports: [
    CommonModule,
    SearchFormModule,
    FlexLayoutModule,
    RouterModule.forChild([{ path: '', component: HomeComponent }]),
  ],
})
export class HomeModule {}
