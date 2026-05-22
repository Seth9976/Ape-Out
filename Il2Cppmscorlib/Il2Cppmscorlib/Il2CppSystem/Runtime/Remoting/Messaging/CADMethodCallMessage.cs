using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003EA RID: 1002
	public class CADMethodCallMessage : CADMessageBase
	{
		// Token: 0x0600408D RID: 16525 RVA: 0x0012DDB8 File Offset: 0x0012BFB8
		// Note: this type is marked as 'beforefieldinit'.
		static CADMethodCallMessage()
		{
			Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADMethodCallMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr);
			CADMethodCallMessage.NativeFieldInfoPtr__uri = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, "_uri");
			CADMethodCallMessage.NativeMethodInfoPtr_get_Uri_Internal_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100672781);
			CADMethodCallMessage.NativeMethodInfoPtr_Create_Internal_Static_CADMethodCallMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100672782);
			CADMethodCallMessage.NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100672783);
			CADMethodCallMessage.NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100672784);
			CADMethodCallMessage.NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100672785);
			CADMethodCallMessage.NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr, 100672786);
		}

		// Token: 0x1700104A RID: 4170
		// (get) Token: 0x0600408E RID: 16526 RVA: 0x0012DE74 File Offset: 0x0012C074
		public unsafe string Uri
		{
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 621, RefRangeEnd = 626, XrefRangeStart = 621, XrefRangeEnd = 626, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_get_Uri_Internal_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600408F RID: 16527 RVA: 0x0012DEAC File Offset: 0x0012C0AC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224319, RefRangeEnd = 224320, XrefRangeStart = 224312, XrefRangeEnd = 224319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CADMethodCallMessage Create(IMessage callMsg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_Create_Internal_Static_CADMethodCallMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CADMethodCallMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06004090 RID: 16528 RVA: 0x0012DEF0 File Offset: 0x0012C0F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 224333, RefRangeEnd = 224334, XrefRangeStart = 224320, XrefRangeEnd = 224333, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADMethodCallMessage(IMethodCallMessage callMsg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADMethodCallMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004091 RID: 16529 RVA: 0x0012DF3C File Offset: 0x0012C13C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224334, XrefRangeEnd = 224347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList GetArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x06004092 RID: 16530 RVA: 0x0012DF7C File Offset: 0x0012C17C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224347, XrefRangeEnd = 224348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetArgs(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x1700104B RID: 4171
		// (get) Token: 0x06004093 RID: 16531 RVA: 0x0012DFCC File Offset: 0x0012C1CC
		public unsafe int PropertiesCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodCallMessage.NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004094 RID: 16532 RVA: 0x0001847C File Offset: 0x0001667C
		public CADMethodCallMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17001049 RID: 4169
		// (get) Token: 0x06004095 RID: 16533 RVA: 0x0012E008 File Offset: 0x0012C208
		// (set) Token: 0x06004096 RID: 16534 RVA: 0x00018485 File Offset: 0x00016685
		public unsafe string _uri
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodCallMessage.NativeFieldInfoPtr__uri);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodCallMessage.NativeFieldInfoPtr__uri), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x040034EB RID: 13547
		private static readonly IntPtr NativeFieldInfoPtr__uri;

		// Token: 0x040034EC RID: 13548
		private static readonly IntPtr NativeMethodInfoPtr_get_Uri_Internal_get_String_0;

		// Token: 0x040034ED RID: 13549
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_CADMethodCallMessage_IMessage_0;

		// Token: 0x040034EE RID: 13550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IMethodCallMessage_0;

		// Token: 0x040034EF RID: 13551
		private static readonly IntPtr NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0;

		// Token: 0x040034F0 RID: 13552
		private static readonly IntPtr NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0;

		// Token: 0x040034F1 RID: 13553
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0;
	}
}
