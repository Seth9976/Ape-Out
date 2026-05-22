using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001C1 RID: 449
	[Serializable]
	public class TypeInfo : Type
	{
		// Token: 0x06001CBB RID: 7355 RVA: 0x000A5B28 File Offset: 0x000A3D28
		// Note: this type is marked as 'beforefieldinit'.
		static TypeInfo()
		{
			Il2CppClassPointerStore<TypeInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "TypeInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr);
			TypeInfo.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100668150);
			TypeInfo.NativeMethodInfoPtr_System_Reflection_IReflectableType_GetTypeInfo_Private_Virtual_Final_New_TypeInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr, 100668151);
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x000A5B80 File Offset: 0x000A3D80
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 186640, RefRangeEnd = 186641, XrefRangeStart = 186637, XrefRangeEnd = 186640, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x000A5BBC File Offset: 0x000A3DBC
		[CallerCount(397)]
		[CachedScanResults(RefRangeStart = 12922, RefRangeEnd = 13319, XrefRangeStart = 12922, XrefRangeEnd = 13319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual TypeInfo System_Reflection_IReflectableType_GetTypeInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInfo.NativeMethodInfoPtr_System_Reflection_IReflectableType_GetTypeInfo_Private_Virtual_Final_New_TypeInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<TypeInfo>(intPtr3) : null;
		}

		// Token: 0x06001CBE RID: 7358 RVA: 0x00009C16 File Offset: 0x00007E16
		public TypeInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001A93 RID: 6803
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

		// Token: 0x04001A94 RID: 6804
		private static readonly IntPtr NativeMethodInfoPtr_System_Reflection_IReflectableType_GetTypeInfo_Private_Virtual_Final_New_TypeInfo_0;
	}
}
