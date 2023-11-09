namespace Api.Funcionalidades.Productos;


    public class ProductoCommandDto
    {
        public required string Nombre{ get; set; }
    }
    public class ProductoQueryDto
    {
        public string Nombre{ get; set; } = string.Empty;
        public double Precio{ get; set; }
        public int Stock{ get; set; }
    }