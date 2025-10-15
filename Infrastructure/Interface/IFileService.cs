﻿using Infrastructure.Models;

namespace Infrastructure.Interface;

public interface IFileService
{
    FileResult SaveContentToFile(string path, string content);
    FileResult GetContentFromFile(string path);
}
