using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Activation;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003EF RID: 1007
	public class ConstructionCallDictionary : MessageDictionary
	{
		// Token: 0x060040D7 RID: 16599 RVA: 0x0012EF78 File Offset: 0x0012D178
		// Note: this type is marked as 'beforefieldinit'.
		static ConstructionCallDictionary()
		{
			Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "ConstructionCallDictionary");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr);
			ConstructionCallDictionary.NativeFieldInfoPtr_InternalKeys = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr, "InternalKeys");
			ConstructionCallDictionary.NativeMethodInfoPtr__ctor_Public_Void_IConstructionCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr, 100672817);
			ConstructionCallDictionary.NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr, 100672818);
			ConstructionCallDictionary.NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr, 100672819);
		}

		// Token: 0x060040D8 RID: 16600 RVA: 0x0012EFF8 File Offset: 0x0012D1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224561, XrefRangeEnd = 224565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstructionCallDictionary(IConstructionCallMessage message)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstructionCallDictionary>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstructionCallDictionary.NativeMethodInfoPtr__ctor_Public_Void_IConstructionCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060040D9 RID: 16601 RVA: 0x0012F044 File Offset: 0x0012D244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224565, XrefRangeEnd = 224617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object GetMethodProperty(string key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCallDictionary.NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_Object_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060040DA RID: 16602 RVA: 0x0012F0A0 File Offset: 0x0012D2A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224617, XrefRangeEnd = 224642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetMethodProperty(string key, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(key);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstructionCallDictionary.NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_Void_String_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060040DB RID: 16603 RVA: 0x00018657 File Offset: 0x00016857
		public ConstructionCallDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x060040DC RID: 16604 RVA: 0x0012F100 File Offset: 0x0012D300
		// (set) Token: 0x060040DD RID: 16605 RVA: 0x00018660 File Offset: 0x00016860
		public unsafe static Il2CppStringArray InternalKeys
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ConstructionCallDictionary.NativeFieldInfoPtr_InternalKeys, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ConstructionCallDictionary.NativeFieldInfoPtr_InternalKeys, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400351D RID: 13597
		private static readonly IntPtr NativeFieldInfoPtr_InternalKeys;

		// Token: 0x0400351E RID: 13598
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IConstructionCallMessage_0;

		// Token: 0x0400351F RID: 13599
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodProperty_Protected_Virtual_Object_String_0;

		// Token: 0x04003520 RID: 13600
		private static readonly IntPtr NativeMethodInfoPtr_SetMethodProperty_Protected_Virtual_Void_String_Object_0;
	}
}
