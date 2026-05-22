using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace Unity.Burst
{
	// Token: 0x0200000A RID: 10
	public sealed class FunctionPointer<T> : ValueType
	{
		// Token: 0x06000049 RID: 73 RVA: 0x000034BC File Offset: 0x000016BC
		// Note: this type is marked as 'beforefieldinit'.
		static FunctionPointer()
		{
			Il2CppClassPointerStore<FunctionPointer<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("Unity.Burst.dll", "Unity.Burst", "FunctionPointer`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FunctionPointer<T>>.NativeClassPtr);
			FunctionPointer<T>.NativeFieldInfoPtr__ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FunctionPointer<T>>.NativeClassPtr, "_ptr");
			FunctionPointer<T>.NativeMethodInfoPtr_get_Invoke_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FunctionPointer<T>>.NativeClassPtr, 100663348);
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00003550 File Offset: 0x00001750
		public unsafe T Invoke
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 439705, RefRangeEnd = 439708, XrefRangeStart = 439700, XrefRangeEnd = 439705, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FunctionPointer<T>.NativeMethodInfoPtr_get_Invoke_Public_get_T_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002234 File Offset: 0x00000434
		public FunctionPointer(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000223D File Offset: 0x0000043D
		public FunctionPointer()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FunctionPointer<T>>.NativeClassPtr))
		{
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00003590 File Offset: 0x00001790
		// (set) Token: 0x0600004E RID: 78 RVA: 0x0000224F File Offset: 0x0000044F
		public unsafe IntPtr _ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionPointer<T>.NativeFieldInfoPtr__ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FunctionPointer<T>.NativeFieldInfoPtr__ptr)) = value;
			}
		}

		// Token: 0x04000039 RID: 57
		private static readonly IntPtr NativeFieldInfoPtr__ptr;

		// Token: 0x0400003A RID: 58
		private static readonly IntPtr NativeMethodInfoPtr_get_Invoke_Public_get_T_0;
	}
}
