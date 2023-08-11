import React from 'react';

const PageWishlist = () => (
  

<section class="section-content padding-y">
<div class="container">

<div class="row">
	<aside class="col-md-3">
	<nav class="list-group">
			<a class="list-group-item" href="page-profile-main.html"> Tổng quan về tài khoản  </a>
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
				<div class="col-md-6">
					<figure class="itemside mb-4">
						<div class="aside"><img src={require("../../assets/images/1.jpg")} className="border img-md" alt="Image description" /></div>
						
						<figcaption class="info">
							<a href="#" class="title">ÁO khoác kiểu croptop</a>
							<p class="price mb-2">$80</p>
							<a href="#" class="btn btn-secondary btn-sm">Thêm vào giỏ hàng </a>
							<a href="#" class="btn btn-danger btn-sm" data-toggle="tooltip" title="" data-original-title="Remove from wishlist"> <i class="fa fa-times"></i> </a>
						</figcaption>
					</figure>
				</div> 

				<div class="col-md-6">
					<figure class="itemside mb-4">
						<div class="aside"><img src={require("../../assets/images/2.jpg")} className="border img-md" alt="Image description" /></div>
						<figcaption class="info">
							<a href="#" class="title">Váy hè màu vàng </a>
							<p class="price mb-2">$1280</p>
							<a href="#" class="btn btn-secondary btn-sm"> Thêm vào giỏ hàng </a>
							<a href="#" class="btn btn-danger btn-sm" data-toggle="tooltip" title="" data-original-title="Remove from wishlist"> <i class="fa fa-times"></i> </a>
						</figcaption>
					</figure>
				</div> 

				<div class="col-md-6">
					<figure class="itemside mb-4">
						<div class="aside"><img src={require("../../assets/images/3.jpg")} className="border img-md" alt="Image description" /></div>
						<figcaption class="info">
							<a href="#" class="title">Áo sơ mi trắng kiểu </a>
							<p class="price mb-2">$280</p>
							<a href="#" class="btn btn-secondary btn-sm">Thêm vào giỏ hàng </a>
							<a href="#" class="btn btn-danger btn-sm" data-toggle="tooltip" title="" data-original-title="Remove from wishlist"> <i class="fa fa-times"></i> </a>
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

export default PageWishlist;