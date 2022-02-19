import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MatCardModule } from '@angular/material/card';
import { MatTabsModule } from '@angular/material/tabs';
import { MatIconModule } from '@angular/material/icon';
import { FlexLayoutModule } from '@angular/flex-layout';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSelectModule } from '@angular/material/select';
import { MatButtonModule } from '@angular/material/button';

import { SearchFormComponent } from './search-form.component';

@NgModule({
  declarations: [SearchFormComponent],
  imports: [
    CommonModule,
    MatCardModule,
    MatTabsModule,
    MatIconModule,
    FlexLayoutModule,
    MatFormFieldModule,
    MatSelectModule,
    MatButtonModule,
  ],
  exports: [SearchFormComponent],
})
export class SearchFormModule {}
