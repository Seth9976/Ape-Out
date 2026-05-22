using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001E6 RID: 486
	[Serializable]
	public class StrongNameKeyPair : Object
	{
		// Token: 0x06001F94 RID: 8084 RVA: 0x000B2508 File Offset: 0x000B0708
		// Note: this type is marked as 'beforefieldinit'.
		static StrongNameKeyPair()
		{
			Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "StrongNameKeyPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr);
			StrongNameKeyPair.NativeFieldInfoPtr__publicKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, "_publicKey");
			StrongNameKeyPair.NativeFieldInfoPtr__keyPairContainer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, "_keyPairContainer");
			StrongNameKeyPair.NativeFieldInfoPtr__keyPairExported = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, "_keyPairExported");
			StrongNameKeyPair.NativeFieldInfoPtr__keyPairArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, "_keyPairArray");
			StrongNameKeyPair.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, 100668609);
			StrongNameKeyPair.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, 100668610);
			StrongNameKeyPair.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr, 100668611);
		}

		// Token: 0x06001F95 RID: 8085 RVA: 0x000B25C4 File Offset: 0x000B07C4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188809, XrefRangeEnd = 188835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe StrongNameKeyPair(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<StrongNameKeyPair>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrongNameKeyPair.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x000B2628 File Offset: 0x000B0828
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 188835, XrefRangeEnd = 188863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_ISerializable_GetObjectData(SerializationInfo info, StreamingContext context)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrongNameKeyPair.NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x000B2684 File Offset: 0x000B0884
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 7, XrefRangeStart = 0, XrefRangeEnd = 7, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void System_Runtime_Serialization_IDeserializationCallback_OnDeserialization(Object sender)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sender);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(StrongNameKeyPair.NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x0000AA5A File Offset: 0x00008C5A
		public StrongNameKeyPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001F99 RID: 8089 RVA: 0x000B26C8 File Offset: 0x000B08C8
		// (set) Token: 0x06001F9A RID: 8090 RVA: 0x0000AA63 File Offset: 0x00008C63
		public unsafe Il2CppStructArray<byte> _publicKey
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__publicKey);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__publicKey), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x000B26F8 File Offset: 0x000B08F8
		// (set) Token: 0x06001F9C RID: 8092 RVA: 0x0000AA82 File Offset: 0x00008C82
		public unsafe string _keyPairContainer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairContainer);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairContainer), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001F9D RID: 8093 RVA: 0x000B2720 File Offset: 0x000B0920
		// (set) Token: 0x06001F9E RID: 8094 RVA: 0x0000AAA1 File Offset: 0x00008CA1
		public unsafe bool _keyPairExported
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairExported);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairExported)) = value;
			}
		}

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001F9F RID: 8095 RVA: 0x000B2748 File Offset: 0x000B0948
		// (set) Token: 0x06001FA0 RID: 8096 RVA: 0x0000AABC File Offset: 0x00008CBC
		public unsafe Il2CppStructArray<byte> _keyPairArray
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairArray);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(StrongNameKeyPair.NativeFieldInfoPtr__keyPairArray), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001CBA RID: 7354
		private static readonly IntPtr NativeFieldInfoPtr__publicKey;

		// Token: 0x04001CBB RID: 7355
		private static readonly IntPtr NativeFieldInfoPtr__keyPairContainer;

		// Token: 0x04001CBC RID: 7356
		private static readonly IntPtr NativeFieldInfoPtr__keyPairExported;

		// Token: 0x04001CBD RID: 7357
		private static readonly IntPtr NativeFieldInfoPtr__keyPairArray;

		// Token: 0x04001CBE RID: 7358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001CBF RID: 7359
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_ISerializable_GetObjectData_Private_Virtual_Final_New_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x04001CC0 RID: 7360
		private static readonly IntPtr NativeMethodInfoPtr_System_Runtime_Serialization_IDeserializationCallback_OnDeserialization_Private_Virtual_Final_New_Void_Object_0;
	}
}
