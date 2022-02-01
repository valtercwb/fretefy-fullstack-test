import { RouterModule, Routes } from '@angular/router';
import { RegiaoComponent } from './regiao.component';
import { AddRegiaoComponent } from './add-regiao/add-regiao.component';

const routes: Routes = [
  {
    path: '',
    component: RegiaoComponent
  }, {
    path: 'regiao/add',
    component: AddRegiaoComponent
  }, {
    path: 'regiao/add/:id',
    component: AddRegiaoComponent
  }
];

export const RegiaoRoutingModule = RouterModule.forChild(routes);