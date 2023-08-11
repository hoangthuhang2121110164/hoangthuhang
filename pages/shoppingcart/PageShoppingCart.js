import React from 'react';

const PageShoppingCart = () => (
  

<section class="section-content padding-y">
<div class="container">

<div class="row">
	<main class="col-md-9">
<div class="card">

<table class="table table-borderless table-shopping-cart">
<thead class="text-muted">
<tr class="small text-uppercase">
  <th scope="col">Sản phẩm</th>
  <th scope="col" width="120">Số lượng</th>
  <th scope="col" width="120">Giá</th>
  <th scope="col" class="text-right" width="200"> </th>
</tr>
</thead>
<tbody>
<tr>
	<td>
		<figure class="itemside">
			<div class="aside"><img src={require("../../assets/images/1.jpg")} className="img-sm" alt="Image description" /></div>
			
			<figcaption class="info">
				<a href="#" class="title text-dark">Áo khoác somi kiểu</a>
				<p class="text-muted small">	Kích cỡ: XL, Màu: blue, <br/> Thương hiệu: BEAND</p>
			</figcaption>
		</figure>
	</td>
	<td> 
		<select class="form-control">
			<option>1</option>
			<option>2</option>	
			<option>3</option>	
			<option>4</option>	
		</select> 
	</td>
	<td> 
		<div class="price-wrap"> 
			<var class="price">$1156.00</var> 
			<small class="text-muted"> $315.20 each </small> 
		</div>
	</td>
	<td class="text-right"> 
	<a data-original-title="Save to Wishlist" title="" href="" class="btn btn-light" data-toggle="tooltip"> <i class="fa fa-heart"></i></a> 
	<a href="" class="btn btn-light"> Remove</a>
	</td>
</tr>
<tr>
	<td>
		<figure class="itemside">
			<div class="aside"><img src={require("../../assets/images/2.jpg")} className="img-sm" alt="Image description" /></div>
			<figcaption class="info">
				<a href="#" class="title text-dark">Aó sơ mi kiểu trắng</a>
				<p class="text-muted small">	Kích cỡ: XL, Màu: blue, <br/> Thương hiệu: BEAND</p>

			</figcaption>
		</figure>
	</td>
	<td> 
		<select class="form-control">
			<option>1</option>
			<option>2</option>	
			<option>3</option>	
			<option>4</option>	
		</select> 
	</td>
	<td> 
		<div class="price-wrap"> 
			<var class="price">$149.97</var> 
			<small  class="text-muted"> $75.00 each </small>  
		</div>
	</td>
	<td class="text-right"> 
	<a data-original-title="Save to Wishlist" title="" href="" class="btn btn-light" data-toggle="tooltip"> <i class="fa fa-heart"></i></a> 
	<a href="" class="btn btn-light btn-round"> Remove</a>
	</td>
</tr>
<tr>
	<td>
		<figure class="itemside">
			<div class="aside"><img src={require("../../assets/images/3.jpg")} className="img-sm" alt="Image description" /></div>
			<figcaption class="info">
				<a href="#" class="title text-dark">Váy hè màu vàng</a>
				<p class="text-muted small">	Kích cỡ: XL, Màu: blue, <br/> Thương hiệu: BEAND</p>

			</figcaption>
		</figure>
	</td>
	<td> 
		<select class="form-control">
			<option>1</option>
			<option>2</option>	
			<option>3</option>	
		</select> 
	</td>
	<td> 
		<div class="price-wrap"> 
			<var class="price">$98.00</var> 
			<small class="text-muted"> $578.00 each</small> 
		</div>
	</td>
	<td class="text-right"> 
		<a data-original-title="Save to Wishlist" title="" href="" class="btn btn-light" data-toggle="tooltip"> <i class="fa fa-heart"></i></a> 
		<a href="" class="btn btn-light btn-round"> Remove</a>
	</td>
</tr>
</tbody>
</table>

<div class="card-body border-top">
	<a href="#" class="btn btn-primary float-md-right"> mua hàng<i class="fa fa-chevron-right"></i> </a>
	<a href="#" class="btn btn-light"> <i class="fa fa-chevron-left"></i> Tiếp tục mua sắm</a>
</div>	
</div> 

<div class="alert alert-success mt-3">
	<p class="icontext"><i class="icon text-success fa fa-truck"></i>Giao hàng miễn phí trong vòng 1-2 tuần</p>
</div>

	</main> 
	<aside class="col-md-3">
		<div class="card mb-3">
			<div class="card-body">
			<form>
				<div class="form-group">
					<label>Có phiếu giảm giá?</label>
					<div class="input-group">
						<input type="text" class="form-control" name="" placeholder="Coupon code"/>
						<span class="input-group-append"> 
							<button class="btn btn-primary">Áp dụng</button>
						</span>
					</div>
				</div>
			</form>
			</div> 
		</div>  
		<div class="card">
			<div class="card-body">
					<dl class="dlist-align">
					  <dt>Tổng giá:</dt>
					  <dd class="text-right">USD 568</dd>
					</dl>
					<dl class="dlist-align">
					  <dt>Giảm giá:</dt>
					  <dd class="text-right">USD 658</dd>
					</dl>
					<dl class="dlist-align">
					  <dt>Tổng cộng:</dt>
					  <dd class="text-right  h5"><strong>$1,650</strong></dd>
					</dl>
					<hr/>
					<p class="text-center mb-3">
						
						<img src={require("../../assets/images/9.jpg")} heightName="26"  />
					</p>
					
			</div> 
		</div>  
	</aside> 
</div>

</div> 
</section>
);

export default PageShoppingCart;