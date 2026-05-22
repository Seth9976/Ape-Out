using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x02000420 RID: 1056
	[Serializable]
	public sealed class RuntimeWrappedException : Exception
	{
		// Token: 0x060042EE RID: 17134 RVA: 0x00136A2C File Offset: 0x00134C2C
		// Note: this type is marked as 'beforefieldinit'.
		static RuntimeWrappedException()
		{
			Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "RuntimeWrappedException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr);
			RuntimeWrappedException.NativeFieldInfoPtr_m_wrappedException = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, "m_wrappedException");
			RuntimeWrappedException.NativeMethodInfoPtr__ctor_Private_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, 100673088);
			RuntimeWrappedException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, 100673089);
			RuntimeWrappedException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, 100673090);
			RuntimeWrappedException.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr, 100673091);
		}

		// Token: 0x060042EF RID: 17135 RVA: 0x00136AC0 File Offset: 0x00134CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226449, XrefRangeEnd = 226455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeWrappedException(Object thrownObject)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(thrownObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeWrappedException.NativeMethodInfoPtr__ctor_Private_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060042F0 RID: 17136 RVA: 0x00136B0C File Offset: 0x00134D0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226455, XrefRangeEnd = 226465, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeWrappedException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042F1 RID: 17137 RVA: 0x00136B68 File Offset: 0x00134D68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226465, XrefRangeEnd = 226478, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeWrappedException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeWrappedException.NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042F2 RID: 17138 RVA: 0x00136BCC File Offset: 0x00134DCC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 226478, XrefRangeEnd = 226481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RuntimeWrappedException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RuntimeWrappedException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RuntimeWrappedException.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060042F3 RID: 17139 RVA: 0x00019547 File Offset: 0x00017747
		public RuntimeWrappedException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x060042F4 RID: 17140 RVA: 0x00136C08 File Offset: 0x00134E08
		// (set) Token: 0x060042F5 RID: 17141 RVA: 0x00019550 File Offset: 0x00017750
		public unsafe Object m_wrappedException
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeWrappedException.NativeFieldInfoPtr_m_wrappedException);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RuntimeWrappedException.NativeFieldInfoPtr_m_wrappedException), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400367F RID: 13951
		private static readonly IntPtr NativeFieldInfoPtr_m_wrappedException;

		// Token: 0x04003680 RID: 13952
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Private_Void_Object_0;

		// Token: 0x04003681 RID: 13953
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003682 RID: 13954
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04003683 RID: 13955
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;
	}
}
