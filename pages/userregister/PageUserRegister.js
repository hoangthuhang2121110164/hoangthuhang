import React from 'react';

const PageUserRegister = () => (
  

<section class="section-content padding-y">


	<div class="card mx-auto" style={{maxwidth:"520px", margintop:"40px"}}>
      <article class="card-body">
		<header class="mb-4"><h4 class="card-title">Đăng ký</h4></header>
		<form>
				<div class="form-row">
					<div class="col form-group">
						<label>Họ</label>
					  	<input type="text" class="form-control" placeholder=""/>
					</div> 
					<div class="col form-group">
						<label>Tên</label>
					  	<input type="text" class="form-control" placeholder=""/>
					</div> 
				</div> 
				<div class="form-group">
					<label>Email</label>
					<input type="email" class="form-control" placeholder=""/>
					<small class="form-text text-muted">Chúng tôi sẽ không bao giờ chia sẻ email của bạn với bất kỳ ai khác.</small>
				</div> 
				<div class="form-group">
					<label class="custom-control custom-radio custom-control-inline">
					  <input class="custom-control-input" checked="" type="radio" name="gender" value="option1"/>
					  <span class="custom-control-label"> Nam  </span>
					</label>
					<label class="custom-control custom-radio custom-control-inline">
					  <input class="custom-control-input" type="radio" name="gender" value="option2"/>
					  <span class="custom-control-label"> Nữ  </span>
					</label>
				</div> 
				<div class="form-row">
					<div class="form-group col-md-6">
					  <label>Thành phố</label>
					  <input type="text" class="form-control"/>
					</div> 
					<div class="form-group col-md-6">
					  <label>Trị TRấn</label>
					  <select id="inputState" class="form-control">
					    <option> Chọn...</option>
					      <option>Việt Nam</option>
					      <option>Trung Quốc</option>
					      <option selected="">United States</option>
					      <option>India</option>
					      <option>Afganistan</option>
					  </select>
					</div> 
				</div> 
				<div class="form-row">
					<div class="form-group col-md-6">
						<label>Tạo mật khẩu</label>
					    <input class="form-control" type="password"/>
					</div> 
					<div class="form-group col-md-6">
						<label>lặp lại mật khẩu</label>
					    <input class="form-control" type="password"/>
					</div> 
				</div>
			    <div class="form-group">
			        <button type="submit" class="btn btn-primary btn-block"> Đăng ký  </button>
			    </div> 
			    <div class="form-group"> 
		            <label class="custom-control custom-checkbox"> <input type="checkbox" class="custom-control-input" checked=""/> <div class="custom-control-label">tôi đồng ý với <a href="#">điều khoản và điều kiện</a>  </div> </label>
		        </div>          
			</form>
		</article>
    </div> 
    <p class="text-center mt-4">Có một tài khoản? <a href="">Đăng nhập</a></p>
    <br/><br/>



</section>
);

export default PageUserRegister;