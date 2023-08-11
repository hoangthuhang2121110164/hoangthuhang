import React from 'react';

const PageUserLogin = () => (
  

<section class="section-conten padding-y" style={{minheight:"84vh"}}>


	<div class="card mx-auto" style={{maxwidth: "380px", margintop:"100px;"}}>
      <div class="card-body">
      <h4 class="card-title mb-4">Đăng nhập</h4>
      <form>
      	  <a href="#" class="btn btn-facebook btn-block mb-2"> <i class="fab fa-facebook-f"></i>&nbsp Đăng nhập bằng Facebook</a>
      	  <a href="#" class="btn btn-google btn-block mb-4"> <i class="fab fa-google"></i> &nbsp  Đăng nhập bằng Google</a>
          <div class="form-group">
			 <input name="" class="form-control" placeholder="Username" type="text"/>
          </div> 
          <div class="form-group">
			<input name="" class="form-control" placeholder="Password" type="password"/>
          </div> 
          
          <div class="form-group">
          	<a href="#" class="float-right">Quên mật khẩu?</a> 
            <label class="float-left custom-control custom-checkbox"> <input type="checkbox" class="custom-control-input" checked=""/> <div class="custom-control-label"> Nhớ tài khoản </div> </label>
          </div> 
          <div class="form-group">
              <button type="submit" class="btn btn-primary btn-block"> Đăng nhập  </button>
          </div> 
      </form>
      </div> 
    </div> 

     <p class="text-center mt-4">Không có tài khoản? <a href="#">Đăng ký</a></p>
     <br/><br/>



</section>
);

export default PageUserLogin;