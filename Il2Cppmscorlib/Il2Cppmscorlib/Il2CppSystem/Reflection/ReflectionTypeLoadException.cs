using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001BB RID: 443
	[Serializable]
	public sealed class ReflectionTypeLoadException : SystemException
	{
		// Token: 0x06001C98 RID: 7320 RVA: 0x000A523C File Offset: 0x000A343C
		// Note: this type is marked as 'beforefieldinit'.
		static ReflectionTypeLoadException()
		{
			Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "ReflectionTypeLoadException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr);
			ReflectionTypeLoadException.NativeFieldInfoPtr__classes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, "_classes");
			ReflectionTypeLoadException.NativeFieldInfoPtr__exceptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, "_exceptions");
			ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100668132);
			ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100668133);
			ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100668134);
			ReflectionTypeLoadException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr, 100668135);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x000A52E4 File Offset: 0x000A34E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186570, XrefRangeEnd = 186573, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionTypeLoadException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x000A5320 File Offset: 0x000A3520
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186573, XrefRangeEnd = 186577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionTypeLoadException(Il2CppReferenceArray<Type> classes, Il2CppReferenceArray<Exception> exceptions)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(classes);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(exceptions);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x000A5380 File Offset: 0x000A3580
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186577, XrefRangeEnd = 186603, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReflectionTypeLoadException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReflectionTypeLoadException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x000A53E4 File Offset: 0x000A35E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 186603, XrefRangeEnd = 186619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReflectionTypeLoadException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x00009B84 File Offset: 0x00007D84
		public ReflectionTypeLoadException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06001C9E RID: 7326 RVA: 0x000A5440 File Offset: 0x000A3640
		// (set) Token: 0x06001C9F RID: 7327 RVA: 0x00009B8D File Offset: 0x00007D8D
		public unsafe Il2CppReferenceArray<Type> _classes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionTypeLoadException.NativeFieldInfoPtr__classes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionTypeLoadException.NativeFieldInfoPtr__classes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06001CA0 RID: 7328 RVA: 0x000A5470 File Offset: 0x000A3670
		// (set) Token: 0x06001CA1 RID: 7329 RVA: 0x00009BAC File Offset: 0x00007DAC
		public unsafe Il2CppReferenceArray<Exception> _exceptions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionTypeLoadException.NativeFieldInfoPtr__exceptions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Exception>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReflectionTypeLoadException.NativeFieldInfoPtr__exceptions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001A5E RID: 6750
		private static readonly IntPtr NativeFieldInfoPtr__classes;

		// Token: 0x04001A5F RID: 6751
		private static readonly IntPtr NativeFieldInfoPtr__exceptions;

		// Token: 0x04001A60 RID: 6752
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;

		// Token: 0x04001A61 RID: 6753
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppReferenceArray_1_Type_Il2CppReferenceArray_1_Exception_0;

		// Token: 0x04001A62 RID: 6754
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001A63 RID: 6755
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;
	}
}
