namespace lab_11
{
	internal static class Client
	{
		public static void Main(string[] args)
		{
			Furniture furniture = new Furniture(
				color: "Темный",
				width: 50,
				height: 70);
			furniture.Show();
			Cabinet cabinet = new Cabinet(
				color: "Красный",
				width: 70,
				height: 120,
				name: "Шкаф Евва УН-03-01/B (белый)",
				material: "ЛДСП (16 мм)");
			cabinet.Show();
			Furniture cabinet2 = new Cabinet(
				color: "Желтый",
				width: 80,
				height: 160,
				name: "Стенка Горизонт Мебель Милан (кантер/сонома)",
				material: "МДФ пленочный");
			cabinet2.Show();
			CabinetBook cabinetBook = new CabinetBook(
				color: "Желтый",
				width: 80,
				height: 160,
				name: "Шкаф-пенал SV-мебель №7 двухстворчатый (ясень анкор светлый)",
				material: "МДФ пленочный",
				filling: 2);
			cabinetBook.Show();
		}
	}
}