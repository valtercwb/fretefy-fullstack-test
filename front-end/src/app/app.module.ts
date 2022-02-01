import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeModule } from './modules/home/home.module';
import { ToolbarModule } from './components/toolbar/toolbar.module';
import { RegiaoModule } from './modules/regiao/regiao.module';
import { RouterModule } from '@angular/router';
import { RegiaoService } from 'src/app/services/regiao.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CidadeService } from './services/cidade.service';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    RouterModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    HomeModule, RegiaoModule,
    ToolbarModule,
    AppRoutingModule,
    BrowserAnimationsModule
  ],
  providers: [
    RegiaoService, CidadeService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
