using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200008B RID: 139
	public class PositionInfo : Object
	{
		// Token: 0x06000E32 RID: 3634 RVA: 0x00051170 File Offset: 0x0004F370
		// Note: this type is marked as 'beforefieldinit'.
		static PositionInfo()
		{
			Il2CppClassPointerStore<PositionInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "PositionInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PositionInfo>.NativeClassPtr);
			PositionInfo.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInfo>.NativeClassPtr, 100665551);
			PositionInfo.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInfo>.NativeClassPtr, 100665552);
			PositionInfo.NativeMethodInfoPtr_GetPositionInfo_Public_Static_PositionInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInfo>.NativeClassPtr, 100665553);
			PositionInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PositionInfo>.NativeClassPtr, 100665554);
		}

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06000E33 RID: 3635 RVA: 0x000511F0 File Offset: 0x0004F3F0
		public unsafe virtual int LineNumber
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PositionInfo.NativeMethodInfoPtr_get_LineNumber_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000E34 RID: 3636 RVA: 0x00051238 File Offset: 0x0004F438
		public unsafe virtual int LinePosition
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), PositionInfo.NativeMethodInfoPtr_get_LinePosition_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x00051280 File Offset: 0x0004F480
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 399129, RefRangeEnd = 399133, XrefRangeStart = 399120, XrefRangeEnd = 399129, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static PositionInfo GetPositionInfo(Object o)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(o);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionInfo.NativeMethodInfoPtr_GetPositionInfo_Public_Static_PositionInfo_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<PositionInfo>(intPtr3) : null;
			}
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x000512C4 File Offset: 0x0004F4C4
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PositionInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PositionInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PositionInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00006D29 File Offset: 0x00004F29
		public PositionInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B04 RID: 2820
		private static readonly IntPtr NativeMethodInfoPtr_get_LineNumber_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000B05 RID: 2821
		private static readonly IntPtr NativeMethodInfoPtr_get_LinePosition_Public_Virtual_New_get_Int32_0;

		// Token: 0x04000B06 RID: 2822
		private static readonly IntPtr NativeMethodInfoPtr_GetPositionInfo_Public_Static_PositionInfo_Object_0;

		// Token: 0x04000B07 RID: 2823
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
