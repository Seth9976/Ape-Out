using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using UnityEngine.Playables;

namespace UnityEngine.Timeline
{
	// Token: 0x0200004B RID: 75
	public class IPropertyPreview : Il2CppObjectBase
	{
		// Token: 0x060004FC RID: 1276 RVA: 0x00003A65 File Offset: 0x00001C65
		// Note: this type is marked as 'beforefieldinit'.
		static IPropertyPreview()
		{
			Il2CppClassPointerStore<IPropertyPreview>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Timeline.dll", "UnityEngine.Timeline", "IPropertyPreview");
			IPropertyPreview.NativeMethodInfoPtr_GatherProperties_Public_Abstract_Virtual_New_Void_PlayableDirector_IPropertyCollector_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPropertyPreview>.NativeClassPtr, 100664117);
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00018258 File Offset: 0x00016458
		[CallerCount(0)]
		public unsafe virtual void GatherProperties(PlayableDirector director, IPropertyCollector driver)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(director);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(driver);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPropertyPreview.NativeMethodInfoPtr_GatherProperties_Public_Abstract_Virtual_New_Void_PlayableDirector_IPropertyCollector_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00003A94 File Offset: 0x00001C94
		public IPropertyPreview(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040003D3 RID: 979
		private static readonly IntPtr NativeMethodInfoPtr_GatherProperties_Public_Abstract_Virtual_New_Void_PlayableDirector_IPropertyCollector_0;
	}
}
