import { Routes } from '@angular/router';
import { ProductComponent } from './components/product/product.component';
import { EditProductComponent } from './components/edit-product/edit-product.component';
import { AddProductComponent } from './components/add-product/add-product.component';



export const routes: Routes = [
  { path: 'add-product', component: AddProductComponent },
  { path: '', component: ProductComponent },
  { path: 'edit-product/:id', component: EditProductComponent },
  { path: '', redirectTo: '/add-product', pathMatch: 'full' },
];
