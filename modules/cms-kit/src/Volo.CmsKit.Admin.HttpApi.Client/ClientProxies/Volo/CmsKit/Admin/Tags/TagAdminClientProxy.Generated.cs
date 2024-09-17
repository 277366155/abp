// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Client.ClientProxying;
using Volo.Abp.Http.Modeling;
using Volo.CmsKit.Admin.Tags;
using Volo.CmsKit.Tags;

// ReSharper disable once CheckNamespace
namespace Volo.CmsKit.Admin.Tags;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(ITagAdminAppService), typeof(TagAdminClientProxy))]
public partial class TagAdminClientProxy : ClientProxyBase<ITagAdminAppService>, ITagAdminAppService
{
    public virtual async Task<TagDto> CreateAsync(TagCreateDto input)
    {
        return await RequestAsync<TagDto>(nameof(CreateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(TagCreateDto), input }
        });
    }

    public virtual async Task DeleteAsync(Guid id)
    {
        await RequestAsync(nameof(DeleteAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<TagDto> GetAsync(Guid id)
    {
        return await RequestAsync<TagDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id }
        });
    }

    public virtual async Task<PagedResultDto<TagDto>> GetListAsync(TagGetListInput input)
    {
        return await RequestAsync<PagedResultDto<TagDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
        {
            { typeof(TagGetListInput), input }
        });
    }

    public virtual async Task<TagDto> UpdateAsync(Guid id, TagUpdateDto input)
    {
        return await RequestAsync<TagDto>(nameof(UpdateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(Guid), id },
            { typeof(TagUpdateDto), input }
        });
    }

    public virtual async Task<List<TagDefinitionDto>> GetTagDefinitionsAsync()
    {
        return await RequestAsync<List<TagDefinitionDto>>(nameof(GetTagDefinitionsAsync));
    }
}
