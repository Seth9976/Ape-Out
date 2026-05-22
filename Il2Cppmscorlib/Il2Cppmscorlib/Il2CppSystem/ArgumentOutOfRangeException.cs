using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000078 RID: 120
	[Serializable]
	public class ArgumentOutOfRangeException : ArgumentException
	{
		// Token: 0x06000745 RID: 1861 RVA: 0x00043E88 File Offset: 0x00042088
		// Note: this type is marked as 'beforefieldinit'.
		static ArgumentOutOfRangeException()
		{
			Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ArgumentOutOfRangeException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr);
			ArgumentOutOfRangeException.NativeFieldInfoPtr__rangeMessage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, "_rangeMessage");
			ArgumentOutOfRangeException.NativeFieldInfoPtr_m_actualValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, "m_actualValue");
			ArgumentOutOfRangeException.NativeMethodInfoPtr_get_RangeMessage_Private_Static_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664436);
			ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664437);
			ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664438);
			ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664439);
			ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664440);
			ArgumentOutOfRangeException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664441);
			ArgumentOutOfRangeException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664442);
			ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr, 100664443);
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00043F80 File Offset: 0x00042180
		public unsafe static string RangeMessage
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 148130, RefRangeEnd = 148133, XrefRangeStart = 148124, XrefRangeEnd = 148130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentOutOfRangeException.NativeMethodInfoPtr_get_RangeMessage_Private_Static_get_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x00043FAC File Offset: 0x000421AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 148135, RefRangeEnd = 148136, XrefRangeStart = 148133, XrefRangeEnd = 148135, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentOutOfRangeException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x00043FE8 File Offset: 0x000421E8
		[CallerCount(77)]
		[CachedScanResults(RefRangeStart = 148138, RefRangeEnd = 148215, XrefRangeStart = 148136, XrefRangeEnd = 148138, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentOutOfRangeException(string paramName)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x00044034 File Offset: 0x00042234
		[CallerCount(100)]
		[CachedScanResults(RefRangeStart = 148216, RefRangeEnd = 148316, XrefRangeStart = 148215, XrefRangeEnd = 148216, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentOutOfRangeException(string paramName, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x00044094 File Offset: 0x00042294
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 148317, RefRangeEnd = 148325, XrefRangeStart = 148316, XrefRangeEnd = 148317, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentOutOfRangeException(string paramName, Object actualValue, string message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(paramName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(actualValue);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Public_Void_String_Object_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x00044104 File Offset: 0x00042304
		public unsafe override string Message
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148325, XrefRangeEnd = 148336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArgumentOutOfRangeException.NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x00044148 File Offset: 0x00042348
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148336, XrefRangeEnd = 148346, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ArgumentOutOfRangeException.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074D RID: 1869 RVA: 0x000441AC File Offset: 0x000423AC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 148346, XrefRangeEnd = 148356, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ArgumentOutOfRangeException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ArgumentOutOfRangeException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x00004506 File Offset: 0x00002706
		public ArgumentOutOfRangeException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x00044210 File Offset: 0x00042410
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x0000450F File Offset: 0x0000270F
		public unsafe static string _rangeMessage
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ArgumentOutOfRangeException.NativeFieldInfoPtr__rangeMessage, (void*)(&intPtr));
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ArgumentOutOfRangeException.NativeFieldInfoPtr__rangeMessage, IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x00044230 File Offset: 0x00042430
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x00004521 File Offset: 0x00002721
		public unsafe Object m_actualValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentOutOfRangeException.NativeFieldInfoPtr_m_actualValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ArgumentOutOfRangeException.NativeFieldInfoPtr_m_actualValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000538 RID: 1336
		private static readonly IntPtr NativeFieldInfoPtr__rangeMessage;

		// Token: 0x04000539 RID: 1337
		private static readonly IntPtr NativeFieldInfoPtr_m_actualValue;

		// Token: 0x0400053A RID: 1338
		private static readonly IntPtr NativeMethodInfoPtr_get_RangeMessage_Private_Static_get_String_0;

		// Token: 0x0400053B RID: 1339
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400053C RID: 1340
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;

		// Token: 0x0400053D RID: 1341
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_String_0;

		// Token: 0x0400053E RID: 1342
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Object_String_0;

		// Token: 0x0400053F RID: 1343
		private static readonly IntPtr NativeMethodInfoPtr_get_Message_Public_Virtual_get_String_0;

		// Token: 0x04000540 RID: 1344
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04000541 RID: 1345
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
