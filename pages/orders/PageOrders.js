import React from 'react';

const PageOrders = () => (
  

<section class="section-content padding-y">
<div class="container">

<div class="row">
	<aside class="col-md-3">
		<nav class="list-group">
			<a class="list-group-item" href="page-profile-main.html">Tổng quan vê tai khoản  </a>
			<a class="list-group-item" href="page-profile-address.html"> Địa chỉ </a>
			<a class="list-group-item active" href="page-profile-orders.html">Đơn hàng </a>
			<a class="list-group-item" href="page-profile-wishlist.html">Sản phẩm yêu thích </a>
			<a class="list-group-item" href="page-profile-seller.html"> 
Mặt hàng bán chạy của tôi </a>
			<a class="list-group-item" href="page-profile-setting.html"> 
Cài đặt </a>
			<a class="list-group-item" href="page-index-1.html">Đăng xuất </a>
		</nav>
	</aside> 
	<main class="col-md-9">

		<article class="card mb-4">
		<header class="card-header">
			<a href="#" class="float-right"> <i class="fa fa-print"></i> In</a>
			<strong class="d-inline-block mr-3">ID đơn hàng: 6123456789</strong>
			<span>Ngày đặt hàng: 8 tháng 8 năm 2023</span>
		</header>
		<div class="card-body">
			<div class="row"> 
				<div class="col-md-8">
					<h6 class="text-muted">Chuyển tới</h6>
					<p>Tp.Hồ Chí Minh <br/>  
					SĐT: 1234567890 Email: hoangthuhang@gmail.com <br/>
			    	Vị trí: 20 tăng nhơn phú,phước long b, Tp.Thủ Đức <br/> 
			    	
			 		</p>
				</div>
				<div class="col-md-4">
					<h6 class="text-muted">Sự chi trả</h6>
					<span class="text-success">
						<i class="fab fa-lg fa-cc-visa"></i>
					    Visa  **** 4216  
					</span>
					<p>Tổng phụ: $356 <br/>
					Phí vận chuyển: $56<br/> 
					 <span class="b">Tổng: $456 </span>
					</p>
				</div>
			</div> 
		</div> 
		<div class="table-responsive">
		<table class="table table-hover">
			<tbody><tr>
				<td width="65">
					
					<img src={require("../../assets/images/1.jpg")} className="img-xs border" alt="Image description" />

				</td>
				<td> 
					<p class="title mb-0">váy mùa hè </p>
					<var class="price text-muted">USD 145</var>
				</td>
				<td> Người bán <br/> trang phục hè </td>
				<td width="250"> <a href="#" class="btn btn-outline-primary">Theo dõi thứ tự</a> 
					<div class="dropdown d-inline-block">
						 <a href="#" data-toggle="dropdown" class="dropdown-toggle btn btn-outline-secondary">Hơn</a>
						 <div class="dropdown-menu dropdown-menu-right">
						 	<a href="#" class="dropdown-item">Trở lại </a>
						 	<a href="#"  class="dropdown-item">Xóa đơn hàng</a>
						 </div>
					</div> 
				</td>
			</tr>
			<tr>
				<td>
				<img src={require("../../assets/images/2.jpg")} className="img-xs border" alt="Image description" />
				</td>
				<td> 
					<p class="title mb-0">ÁO HTH </p>
					<var class="price text-muted">USD 15</var>
				</td>
				<td> Người bán <br/> ABC </td>
				<td> 
					<a href="#" class="btn btn-outline-primary">Theo dõi thứ tự</a>
					<div class="dropdown d-inline-block">
						 <a href="#" data-toggle="dropdown" class="dropdown-toggle btn btn-outline-secondary">Hơn</a>
						 <div class="dropdown-menu dropdown-menu-right">
						 	<a href="#" class="dropdown-item">Trở lại</a>
						 	<a href="#"  class="dropdown-item">Hủy đơn hàng</a>
						 </div>
					</div> 
				</td>
			</tr>
			<tr>
				<td>
				<img src={require("../../assets/images/3.jpg")} className="img-xs border" alt="Image description" />
				</td>
				<td> 
					<p class="title mb-0">Váy maxi vàng </p>
					<var class="price text-muted">USD 145</var>
				</td>
				<td>Người bán<br/> Wallmart </td>
				<td> <a href="#" class="btn btn-outline-primary">Theo dõi thứ tự</a> 
					<div class="dropdown d-inline-block">
						 <a href="#" data-toggle="dropdown" class="dropdown-toggle btn btn-outline-secondary">Hơn</a>
						 <div class="dropdown-menu dropdown-menu-right">
						 	<a href="#" class="dropdown-item">Trở lại</a>
						 	<a href="#"  class="dropdown-item">Hủy đơn hàng</a>
						 </div>
					</div> 
				</td>
			</tr>
		</tbody></table>
		</div>
		</article> 


		<article class="card order-item mb-4">
		<header class="card-header">
			<a href="#" class="float-right"> <i class="fa fa-print"></i> In</a>
			<strong class="d-inline-block mr-3">Mã đơn hàng: 6123456789</strong>
			<span>Ngày đặt hàng: 8 tháng 8 năm 2023</span>
		</header>
		<div class="card-body">
			<div class="row"> 
				<div class="col-md-8">
					<h6 class="text-muted">
Chuyển tới</h6>
					<p>Michael Jackson <br/>  
					SDT: 1234567890 Email: myname@pixsellz.com <br/>
			    	
Vị trí: 20 tăng nhơn phú,phước long b, Tp.Thủ Đức<br/> 
			    	
			 		</p>
				</div>
				<div class="col-md-4">
					<h6 class="text-muted">Sự chi trả</h6>
					<span class="text-success">
						<i class="fab fa-lg fa-cc-visa"></i>
					    Visa  **** 4216  
					</span>
					<p>Tổng phụ: $356 <br/>
					Phí vận chuyển: $56<br/> 
					 <span class="b">Tổng: $456 </span>
					</p>
				</div>
			</div> 
		</div> 
		<div class="table-responsive">
		<table class="table table-hover">
			<tbody><tr>
				<td>
				<img src={require("../../assets/images/3.jpg")} className="img-xs border" alt="Image description" />
				</td>
				<td> 
					<p class="title mb-0">Váy maxi vàng </p>
					<var class="price text-muted">USD 145</var>
				</td>
				<td>Người bán<br/> Wallmart </td>
				<td> <a href="#" class="btn btn-outline-primary">Theo dõi thứ tự</a> 
					<div class="dropdown d-inline-block">
						 <a href="#" data-toggle="dropdown" class="dropdown-toggle btn btn-outline-secondary">Hơn</a>
						 <div class="dropdown-menu dropdown-menu-right">
						 	<a href="#" class="dropdown-item">Trở lại</a>
						 	<a href="#"  class="dropdown-item">Hủy đơn hàng</a>
						 </div>
					</div> 
				</td>
			</tr>
			<tr>
				<td>
				<img src={require("../../assets/images/9.jpg")} className="img-xs border" alt="Image description" />
				</td>
				<td> 
					<p class="title mb-0">Áo polo </p>
					<var class="price text-muted">USD 145</var>
				</td>
				<td>Người bán<br/> Wallmart </td>
				<td> <a href="#" class="btn btn-outline-primary">Theo dõi thứ tự</a> 
					<div class="dropdown d-inline-block">
						 <a href="#" data-toggle="dropdown" class="dropdown-toggle btn btn-outline-secondary">Hơn</a>
						 <div class="dropdown-menu dropdown-menu-right">
						 	<a href="#" class="dropdown-item">Trở lại</a>
						 	<a href="#"  class="dropdown-item">Hủy đơn hàng</a>
						 </div>
					</div> 
				</td>
			</tr>
		</tbody></table>
		</div>
		</article> 


	</main> 
</div>

</div> 
</section>
);

export default PageOrders;