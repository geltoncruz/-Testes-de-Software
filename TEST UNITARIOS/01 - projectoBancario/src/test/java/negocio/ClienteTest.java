package negocio;
import negocio.Cliente;
import org.junit.*;

public class ClienteTest {
	
	
	
	
	@Test
	public void testarIdValido(){
		Cliente c1 = new Cliente();
		c1.setId(1);
		Assert.assertEquals(c1.getId(), 1);
	}
	
	@Test
	public void testarNegativoInvalido(){
		Cliente c1 = new Cliente();
		c1.setId(1);
		
		boolean status = false;
		
		if(c1.getId() >= 1){
			status = true;
		}
		Assert.assertTrue(status);
	}

}
