import React from 'react';

const PageSeller = () => (
  

<section class="section-content padding-y">
<div class="container">

<div class="row">
	<aside class="col-md-3">
		<nav class="list-group">
			<a class="list-group-item" href="page-profile-main.html"> Tổng quan vê tai khoản  </a>
			<a class="list-group-item" href="page-profile-address.html">Địa chỉ tôi </a>
			<a class="list-group-item" href="page-profile-orders.html"> Đơn hàng cua tôi </a>
			<a class="list-group-item" href="page-profile-wishlist.html"> Sản phẩm yêu thích</a>
			<a class="list-group-item active" href="page-profile-seller.html">Mặt hàng bán chạy của tôi </a>
			<a class="list-group-item" href="page-profile-setting.html"> 	Cài đặt</a>
			<a class="list-group-item" href="page-index-1.html"> Đăng xuất xuất </a>
		</nav>
	</aside> 
	<main class="col-md-9">

		<article class="card">
			<div class="card-body">

		<div class="row">
				<div class="col-md-4">
					<figure class="card card-product-grid">
						<div class="img-wrap"> 
						<img src={require("../../assets/images/1.jpg")} style={{ width: "100%", height: "145%", objectFit: "cover" }} />
						</div> 
						<figcaption class="info-wrap">
								<a href="#" class="title mb-2">Áo khoác sơ mi croptop</a>
								<div class="price-wrap mb-3">
									<span class="price">$32.00-$40.00</span> 
									<small class="text-muted">/per item</small>
								</div> 
								<a href="#" class="btn btn-outline-primary"> <i class="fa fa-pen"></i> Sửa </a>
								<a href="#" class="btn btn-primary"> <i class="fa fa-eye"></i> Xem  </a>
								
								<hr/>
								<a href="#" class="btn bg-gray btn-block">  Thêm vào Giỏ Hàng </a>
						</figcaption>
					</figure>
				</div> 

				<div class="col-md-4">
					<figure class="card card-product-grid">
						<div class="img-wrap"> 
						<img src={require("../../assets/images/2.jpg")} style={{ width: "100%", height: "145%", objectFit: "cover" }} />
						</div> 
						<figcaption class="info-wrap">
								<a href="#" class="title mb-2">Áo sơ mi trắng balo kiểu mới</a>
								<div class="price-wrap mb-3">
									<span class="price">$41.00-$50.00</span> 
									<small class="text-muted">/per item</small>
								</div> 
								<a href="#" class="btn btn-outline-primary"> <i class="fa fa-pen"></i> Sửa </a>
								<a href="#" class="btn btn-primary"> <i class="fa fa-eye"></i> Xem  </a>
								
								<hr/>
								<a href="#" class="btn bg-gray btn-block">  Thêm vào Giỏ Hàng</a>
						</figcaption>
					</figure>
				</div> 

				<div class="col-md-4">
					<figure class="card card-product-grid">
						<div class="img-wrap"> 
						<img src={require("../../assets/images/3.jpg")} style={{ width: "100%", height: "120%", objectFit: "cover" }} />
						</div> 
						<figcaption class="info-wrap">
								<a href="#" class="title mb-2">Váy hè màu vàng</a>
								<div class="price-wrap mb-3">
									<span class="price">$32.00-$40.00</span> 
									<small class="text-muted">/per item</small>
								</div> 
								<a href="#" class="btn btn-outline-primary"> <i class="fa fa-pen"></i> Sửa </a>
								<a href="#" class="btn btn-primary"> <i class="fa fa-eye"></i> Xem  </a>
								
								<hr/>
								<a href="#" class="btn bg-gray btn-block">  Thêm vào Giỏ Hàng </a>
						</figcaption>
					</figure>
				</div> 

				<div class="col-md-4">
					<figure class="card card-product-grid">
						<div class="img-wrap"> 
						<img src={require("../../assets/images/4.jpg")} style={{ width: "100%", height: "145%", objectFit: "cover" }} />						</div> 
						<figcaption class="info-wrap">
								<a href="#" class="title mb-2">Váy đen hè </a>
								<div class="price-wrap mb-3">
									<span class="price">$32.00-$40.00</span> 
									<small class="text-muted">/per item</small>
								</div> 
								<a href="#" class="btn btn-outline-primary"> <i class="fa fa-pen"></i> Sửa </a>
								<a href="#" class="btn btn-primary"> <i class="fa fa-eye"></i> Xem  </a>
								
								<hr/>
								<a href="#" class="btn bg-gray btn-block">  Thêm vào Giỏ Hàng </a>
						</figcaption>
					</figure>
				</div> 

				<div class="col-md-4">
					<figure class="card card-product-grid">
						<div class="img-wrap"> 
						<img src={require("../../assets/images/5.jpg")} style={{ width: "100%", height: "145%", objectFit: "cover" }} />						</div> 
						<figcaption class="info-wrap">
								<a href="#" class="title mb-2">Đầm tiệc be</a>
								<div class="price-wrap mb-3">
									<span class="price">$32.00-$40.00</span> 
									<small class="text-muted">/per item</small>
								</div> 
								<a href="#" class="btn btn-outline-primary"> <i class="fa fa-pen"></i> Sửa </a>
								<a href="#" class="btn btn-primary"> <i class="fa fa-eye"></i> Xem  </a>
								
								<hr/>
								<a href="#" class="btn bg-gray btn-block">  Thêm vào Giỏ Hàng </a>
						</figcaption>
					</figure>
				</div> 

			</div>

			</div> 
		</article>


	</main> 
</div>

</div> 
</section>
);

export default PageSeller;