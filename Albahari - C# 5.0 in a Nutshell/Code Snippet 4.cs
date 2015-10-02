public static IEnumerable<TSource> Where<TSource>
(this IEnumerable<TSource> source, Func<TSource,bool> predicate)
{
	foreach(TSource element in source)
		if(predicate(element))
			yield return element;
}