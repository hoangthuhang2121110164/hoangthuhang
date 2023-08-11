import React from 'react';

const PagePayment = () => (
  

<section class="section-content padding-y">
<div class="container" style={{maxwidth: "720px;"}}>

<div class="card mb-4">
      <div class="card-body">
      <h4 class="card-title mb-3">thông tin giao hàng</h4>

	  <div class="form-row">
			<div class="form-group col-sm-6">
				<label class="js-check box active">
					<input type="radio" name="dostavka" value="option1" checked/>
					<h6 class="title">giao hàng tiêu chuẩn</h6>
					<p class="text-muted">Miễn phí theo hãng hàng không trong vòng 20 ngày</p>
				</label> 
			</div>
			<div class="form-group col-sm-6">
				<label class="js-check box">
					<input type="radio" name="dostavka" value="option1"/>
					<h6 class="title">Chuyển phát nhanh</h6>
					<p class="text-muted">Thêm 20 đô la sẽ được tính phí</p>
				</label> 
			</div>
		</div>

	<div class="form-row">
		<div class="col form-group">
			<label>Tên </label>
		  	<input type="text" class="form-control" placeholder=""/>
		</div> 
		<div class="col form-group">
			<label>Họ</label>
		  	<input type="text" class="form-control" placeholder=""/>
		</div> 
	</div> 

	<div class="form-row">
		<div class="col form-group">
			<label>Email</label>
		  	<input type="email" class="form-control" placeholder=""/>
		</div> 
		<div class="col form-group">
			<label>Số điện thoại</label>
		  	<input type="text" class="form-control" placeholder=""/>
		</div> 
	</div> 

	<div class="form-row">
		<div class="form-group col-md-6">
		  <label>Quốc gia</label>
		  <select id="inputState" class="form-control">
		    <option> Chọn...</option>
		      <option>Việt Nam</option>
		      <option>Hàn quốc</option>
		      <option selected="">Trung Quốc</option>
		      <option>India</option>
		      <option>Thái Lan</option>
		  </select>
		</div> 
		<div class="form-group col-md-6">
		  <label>Công ty</label>
		  <input type="text" class="form-control"/>
		</div> 
	</div> 
	<div class="form-group">
		<label>Địa chỉ</label>
       <textarea class="form-control" rows="2"></textarea>
    </div> 

      </div> 
    </div>  


		<div class="card mb-4">
      <div class="card-body">
      <h4 class="card-title mb-4">Chi trả</h4>
      <form role="form" style={{maxwidth:"380px;"}}>
			<div class="form-group">
			<label for="username"> Tên trên thẻ</label>
			<input type="text" class="form-control" name="username" placeholder="Ex. John Smith" required=""/>
			</div> 

			<div class="form-group">
			<label for="cardNumber">Số Thẻ</label>
			<div class="input-group">
				<input type="text" class="form-control" name="cardNumber" placeholder=""/>
				<div class="input-group-append">
					<span class="input-group-text">
						<i class="fab fa-cc-visa"></i> &nbsp; <i class="fab fa-cc-amex"></i> &nbsp; 
						<i class="fab fa-cc-mastercard"></i> 
					</span>
				</div>
			</div> 
			</div> 

			<div class="row">
				<div class="col-md flex-grow-0">
					<div class="form-group">
						<label class="hidden-xs">hết hạn</label>
						<div class="form-inline" style={{minwidth: "220px"}}>
							<select class="form-control" style={{width:"100px"}}>
								<option>MM</option>
								<option>01 - Janiary</option>
								<option>02 - February</option>
								<option>03 - February</option>
							</select>
							<span style={{ width: "20px", textAlign: "center" }}> / </span>
							<select class="form-control" style={{width:"100px"}}>
								<option>YY</option>
								<option>2018</option>
								<option>2023</option>
							</select>
						</div>
					</div>
				</div>
				<div class="col-md-3">
					<div class="form-group">
						<label data-toggle="tooltip" title="3 digits code on back side of the card">CVV <i class="fa fa-question-circle"></i></label>
						<input class="form-control" required="" type="text"/>
					</div> 
				</div>
			</div> 
			<button class="subscribe btn btn-primary btn-block" type="button"> Xác nhận  </button>
		</form>
      </div> 
    </div> 


<br/><br/> 

</div> 
</section>
);

export default PagePayment;