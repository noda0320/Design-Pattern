
namespace DesignPatterns.Iterator
{
	/// <summary>
	/// 先頭から順番に取得していくイテレータ
	/// </summary>
	class PreIterator<Type> : AIterator<Type>
	{
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="type">使用する配列データ</param>
		public PreIterator(Type[] type)
			: base(type)
		{ }

		/// <summary>
		/// データを先頭にする
		/// </summary>
		public override void First()
		{
			index = 0;
		}

		/// <summary>
		/// まだデータがあるかチェックする
		/// </summary>
		/// <returns>true:データ有,false:データ無</returns>
		public override bool IsDone()
		{
			return (list.Length > index && list[index] != null);
		}

		/// <summary>
		/// データを次にする
		/// </summary>
		public override void Next()
		{
			index++;
		}
	}
}
