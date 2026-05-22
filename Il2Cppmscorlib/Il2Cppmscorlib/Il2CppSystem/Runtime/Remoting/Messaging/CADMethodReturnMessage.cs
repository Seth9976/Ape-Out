using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting.Messaging
{
	// Token: 0x020003EB RID: 1003
	public class CADMethodReturnMessage : CADMessageBase
	{
		// Token: 0x06004097 RID: 16535 RVA: 0x0012E030 File Offset: 0x0012C230
		// Note: this type is marked as 'beforefieldinit'.
		static CADMethodReturnMessage()
		{
			Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Messaging", "CADMethodReturnMessage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr);
			CADMethodReturnMessage.NativeFieldInfoPtr__returnValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, "_returnValue");
			CADMethodReturnMessage.NativeFieldInfoPtr__exception = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, "_exception");
			CADMethodReturnMessage.NativeFieldInfoPtr__sig = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, "_sig");
			CADMethodReturnMessage.NativeMethodInfoPtr_Create_Internal_Static_CADMethodReturnMessage_IMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100672787);
			CADMethodReturnMessage.NativeMethodInfoPtr__ctor_Internal_Void_IMethodReturnMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100672788);
			CADMethodReturnMessage.NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100672789);
			CADMethodReturnMessage.NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100672790);
			CADMethodReturnMessage.NativeMethodInfoPtr_GetReturnValue_Internal_Object_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100672791);
			CADMethodReturnMessage.NativeMethodInfoPtr_GetException_Internal_Exception_ArrayList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100672792);
			CADMethodReturnMessage.NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr, 100672793);
		}

		// Token: 0x06004098 RID: 16536 RVA: 0x0012E128 File Offset: 0x0012C328
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224348, XrefRangeEnd = 224355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static CADMethodReturnMessage Create(IMessage callMsg)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_Create_Internal_Static_CADMethodReturnMessage_IMessage_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<CADMethodReturnMessage>(intPtr3) : null;
			}
		}

		// Token: 0x06004099 RID: 16537 RVA: 0x0012E16C File Offset: 0x0012C36C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 224383, RefRangeEnd = 224386, XrefRangeStart = 224355, XrefRangeEnd = 224383, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CADMethodReturnMessage(IMethodReturnMessage retMsg)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CADMethodReturnMessage>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(retMsg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr__ctor_Internal_Void_IMethodReturnMessage_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600409A RID: 16538 RVA: 0x0012E1B8 File Offset: 0x0012C3B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224386, XrefRangeEnd = 224399, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ArrayList GetArguments()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr3) : null;
		}

		// Token: 0x0600409B RID: 16539 RVA: 0x0012E1F8 File Offset: 0x0012C3F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Il2CppReferenceArray<Object> GetArgs(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x0600409C RID: 16540 RVA: 0x0012E248 File Offset: 0x0012C448
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224399, XrefRangeEnd = 224400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object GetReturnValue(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_GetReturnValue_Internal_Object_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600409D RID: 16541 RVA: 0x0012E298 File Offset: 0x0012C498
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 224400, XrefRangeEnd = 224402, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception GetException(ArrayList args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_GetException_Internal_Exception_ArrayList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x1700104F RID: 4175
		// (get) Token: 0x0600409E RID: 16542 RVA: 0x0012E2E8 File Offset: 0x0012C4E8
		public unsafe int PropertiesCount
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CADMethodReturnMessage.NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600409F RID: 16543 RVA: 0x000184A4 File Offset: 0x000166A4
		public CADMethodReturnMessage(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700104C RID: 4172
		// (get) Token: 0x060040A0 RID: 16544 RVA: 0x0012E324 File Offset: 0x0012C524
		// (set) Token: 0x060040A1 RID: 16545 RVA: 0x000184AD File Offset: 0x000166AD
		public unsafe Object _returnValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__returnValue);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__returnValue), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104D RID: 4173
		// (get) Token: 0x060040A2 RID: 16546 RVA: 0x0012E354 File Offset: 0x0012C554
		// (set) Token: 0x060040A3 RID: 16547 RVA: 0x000184CC File Offset: 0x000166CC
		public unsafe CADArgHolder _exception
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__exception);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<CADArgHolder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__exception), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700104E RID: 4174
		// (get) Token: 0x060040A4 RID: 16548 RVA: 0x0012E384 File Offset: 0x0012C584
		// (set) Token: 0x060040A5 RID: 16549 RVA: 0x000184EB File Offset: 0x000166EB
		public unsafe Il2CppReferenceArray<Type> _sig
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__sig);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Type>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CADMethodReturnMessage.NativeFieldInfoPtr__sig), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040034F2 RID: 13554
		private static readonly IntPtr NativeFieldInfoPtr__returnValue;

		// Token: 0x040034F3 RID: 13555
		private static readonly IntPtr NativeFieldInfoPtr__exception;

		// Token: 0x040034F4 RID: 13556
		private static readonly IntPtr NativeFieldInfoPtr__sig;

		// Token: 0x040034F5 RID: 13557
		private static readonly IntPtr NativeMethodInfoPtr_Create_Internal_Static_CADMethodReturnMessage_IMessage_0;

		// Token: 0x040034F6 RID: 13558
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_IMethodReturnMessage_0;

		// Token: 0x040034F7 RID: 13559
		private static readonly IntPtr NativeMethodInfoPtr_GetArguments_Internal_ArrayList_0;

		// Token: 0x040034F8 RID: 13560
		private static readonly IntPtr NativeMethodInfoPtr_GetArgs_Internal_Il2CppReferenceArray_1_Object_ArrayList_0;

		// Token: 0x040034F9 RID: 13561
		private static readonly IntPtr NativeMethodInfoPtr_GetReturnValue_Internal_Object_ArrayList_0;

		// Token: 0x040034FA RID: 13562
		private static readonly IntPtr NativeMethodInfoPtr_GetException_Internal_Exception_ArrayList_0;

		// Token: 0x040034FB RID: 13563
		private static readonly IntPtr NativeMethodInfoPtr_get_PropertiesCount_Internal_get_Int32_0;
	}
}
