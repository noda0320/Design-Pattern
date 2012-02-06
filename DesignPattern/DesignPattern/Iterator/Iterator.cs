
namespace DesignPatterns.Iterator
{
	/// <summary>
	/// イテレータ用抽象クラス
	/// </summary>
	abstract class AIterator<Type>
	{
 		protected Type[] list;
		protected int index;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="data">データ配列</param>
		protected AIterator(Type[] data)
		{
			list = data;
			First();
		}

		abstract public void First();
		abstract public bool IsDone();
		abstract public void Next();

		/// <summary>
		/// 現在のデータを取得する
		/// </summary>
		/// <returns>現在位置のデータ</returns>
		public Type Current()
		{
			return list[index];
		}
	}
}
