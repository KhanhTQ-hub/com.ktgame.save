using com.ktgame.save.core;

namespace com.ktgame.save.file
{
	public interface IFileStorage : IStorageProvider
	{
		string GetFilePath(string fileName);
	}
}
