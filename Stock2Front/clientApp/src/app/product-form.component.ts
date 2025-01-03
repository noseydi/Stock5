import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Product } from '../models/product.model';

@Component({
  selector: 'app-product-form',
  templateUrl: './product-form.component.html',
  styleUrls: ['./product-form.component.css']
})
export class ProductFormComponent implements OnInit {
  productForm: FormGroup;

  constructor(private fb: FormBuilder) {
    this.productForm = this.fb.group({
      productID: [0, Validators.required],
      productName: ['', [Validators.required, Validators.minLength(3)]],
      dimensions: [0, [Validators.required, Validators.min(1)]]
    });
  }

  ngOnInit(): void { }

  onSubmit(): void {
    if (this.productForm.valid) {
      const product: Product = this.productForm.value;
      console.log('Form Submitted:', product);
      // Call API to save product
    }
  }
}
