using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UI
{
	// Token: 0x02000040 RID: 64
	public class BaseVertexEffect : Object
	{
		// Token: 0x06000821 RID: 2081 RVA: 0x00026618 File Offset: 0x00024818
		// Note: this type is marked as 'beforefieldinit'.
		static BaseVertexEffect()
		{
			Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "BaseVertexEffect");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr);
			BaseVertexEffect.NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr, 100664616);
			BaseVertexEffect.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr, 100664617);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x00026670 File Offset: 0x00024870
		[CallerCount(0)]
		public unsafe virtual void ModifyVertices(List<UIVertex> vertices)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vertices);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), BaseVertexEffect.NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x000266C0 File Offset: 0x000248C0
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseVertexEffect()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseVertexEffect>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseVertexEffect.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00004D42 File Offset: 0x00002F42
		public BaseVertexEffect(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000632 RID: 1586
		private static readonly IntPtr NativeMethodInfoPtr_ModifyVertices_Public_Abstract_Virtual_New_Void_List_1_UIVertex_0;

		// Token: 0x04000633 RID: 1587
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
