import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { ProductService } from '../../services/product.service';
import { FormsModule } from '@angular/forms'; 
import { CommonModule } from '@angular/common';  
import { RouterModule } from '@angular/router';


@Component({
  selector: 'app-edit-product',
  standalone: true, 
  imports: [CommonModule, FormsModule,RouterModule], 
  templateUrl: './edit-product.component.html',
  styleUrls: ['./edit-product.component.css']
})
export class EditProductComponent implements OnInit {
  product: any = { id: 0, name: '', price: 0, description: '' };

  constructor(
    private route: ActivatedRoute,
    private productService: ProductService,
    private router: Router
  ) {}

  ngOnInit(): void {
    const id = this.route.snapshot.paramMap.get('id');
    if (id) {
      this.getProductById(+id);
    }
  }

  getProductById(id: number): void {
    this.productService.getProductById(id).subscribe((data) => {
      this.product = data;
    });
  }

  updateProduct(): void {
    this.productService.updateProduct(this.product.id,this.product).subscribe(() => {
      this.router.navigate(['/']); 
    });
  }
}
