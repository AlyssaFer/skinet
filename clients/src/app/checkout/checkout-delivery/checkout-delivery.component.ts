import { Component, Input } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { DeliveryMethod } from 'src/app/shared/models/deliveryMethod';
import { CheckoutService } from '../checkout.service';
import { BasketService } from 'src/app/basket/basket.service';

@Component({
  selector: 'app-checkout-delivery',
  templateUrl: './checkout-delivery.component.html',
  styleUrls: ['./checkout-delivery.component.scss']
})
export class CheckoutDeliveryComponent {
  @Input() checkoutForm?: FormGroup;
  deliveryMethods: DeliveryMethod[] = [];

  constructor(private checkoutService: CheckoutService, private basketService: BasketService) {}

  ngOnInit(): void {
    this.checkoutService.getDeliveryMethods().subscribe({
      next: dm => this.deliveryMethods = dm
    })
  }

  setShippingPrice(deliverMethod: DeliveryMethod){
    this.basketService.setShippingPrice(deliverMethod);
  }
}
