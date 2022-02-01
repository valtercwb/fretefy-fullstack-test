import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegiaoComponent } from './regiao.component';
import { AddRegiaoComponent } from './add-regiao/add-regiao.component';
import { RegiaoRoutingModule } from './regiao.routing';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CidadeComponent } from './cidade/cidade.component';
import { MatSelectModule } from '@angular/material/select';


@NgModule({
  imports: [
    CommonModule,
    RegiaoRoutingModule,
    FormsModule,
    MatSelectModule,
    ReactiveFormsModule,
  ],
  declarations: [RegiaoComponent, AddRegiaoComponent, CidadeComponent],
  exports: [RegiaoComponent]
})
export class RegiaoModule { }
