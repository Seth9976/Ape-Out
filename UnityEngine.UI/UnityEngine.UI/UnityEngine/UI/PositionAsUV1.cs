using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine.UI
{
	// Token: 0x02000045 RID: 69
	public class PositionAsUV1 : BaseMeshEffect
	{
		// Token: 0x0600083B RID: 2107 RVA: 0x00026BF0 File Offset: 0x00024DF0
		// Note: this type is marked as 'beforefieldinit'.
		static PositionAsUV1()
		{
			Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UI.dll", "UnityEngine.UI", "PositionAsUV1");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr);
			PositionAsUV1.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr, 100664630);
			PositionAsUV1.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr, 100664631);
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x00026C48 File Offset: 0x00024E48
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PositionAsUV1()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionAsUV1>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionAsUV1.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x00026C84 File Offset: 0x00024E84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 530109, XrefRangeEnd = 530117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void ModifyMesh(VertexHelper vh)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(vh);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PositionAsUV1.NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00004DBD File Offset: 0x00002FBD
		public PositionAsUV1(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000641 RID: 1601
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04000642 RID: 1602
		private static readonly IntPtr NativeMethodInfoPtr_ModifyMesh_Public_Virtual_Void_VertexHelper_0;
	}
}
