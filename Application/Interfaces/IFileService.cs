using Application.Dtos;
using Application.Models;

namespace Application.Interfaces;

public interface IFileService
{
    bool SaveContentToFile(string content);
    string GetContentFromFile();
}


