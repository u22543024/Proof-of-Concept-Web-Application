import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ProductService } from '../../services/product.service';
import { FormsModule } from '@angular/forms'; 
import { CommonModule } from '@angular/common';  
import { RouterModule } from '@angular/router';
import { Product } from '../../models/product.model'; 

@Component({
  selector: 'app-add-product',
  standalone: true, 
  imports: [CommonModule, FormsModule, RouterModule], 
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent {
  product: Product = { id: 0, name: '', price: 0, description: '' }; 

  constructor(
    private productService: ProductService,
    public router: Router
  ) {}

  addProduct(): void {
    this.productService.addProduct(this.product).subscribe(() => {
      alert('Product added successfully!');
      this.router.navigate(['/']);
    });
  }
}
