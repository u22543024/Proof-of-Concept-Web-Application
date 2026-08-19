import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { ProductService } from '../../services/product.service';
import { Product } from '../../models/product.model';
import { RouterModule } from '@angular/router'

@Component({
  selector: 'app-product',
  standalone: true,
  imports: [CommonModule, FormsModule,RouterModule],
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  products: Product[] = [];
  newProduct: Product = { id: 0, name: '', price: 0, description: '' };

  constructor(private productService: ProductService) {}

  ngOnInit(): void {
    this.loadProducts();
  }
  confirmDelete(Id: number) {
    if (confirm("Are you sure you want to delete this product?")) {
      this.deleteProduct(Id);
    }
  }

  loadProducts(): void {
    this.productService.getProducts().subscribe((data) => {
      this.products = data;
    });
  }

  addProduct(): void {
    this.productService.addProduct(this.newProduct).subscribe(() => {
      this.loadProducts();
      this.newProduct = { id: 0, name: '', price: 0, description:''};
    });
  }

  deleteProduct(id: number): void {
    this.productService.deleteProduct(id).subscribe(() => this.loadProducts());
  }
  
  editProduct(productId: number): void {
    const productToEdit = this.products.find(product => product.id === productId);
    if (productToEdit) {
      
      this.productService.updateProduct(productId, productToEdit).subscribe(() => {
        this.loadProducts(); 
      });
    }
  }
}
