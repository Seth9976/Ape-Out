using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x02000383 RID: 899
	public sealed class SerStack : Object
	{
		// Token: 0x06003B8A RID: 15242 RVA: 0x0011C618 File Offset: 0x0011A818
		// Note: this type is marked as 'beforefieldinit'.
		static SerStack()
		{
			Il2CppClassPointerStore<SerStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Serialization.Formatters.Binary", "SerStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerStack>.NativeClassPtr);
			SerStack.NativeFieldInfoPtr_objects = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerStack>.NativeClassPtr, "objects");
			SerStack.NativeFieldInfoPtr_stackId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerStack>.NativeClassPtr, "stackId");
			SerStack.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerStack>.NativeClassPtr, "top");
			SerStack.NativeMethodInfoPtr__ctor_Internal_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100672209);
			SerStack.NativeMethodInfoPtr_Push_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100672210);
			SerStack.NativeMethodInfoPtr_Pop_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100672211);
			SerStack.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100672212);
			SerStack.NativeMethodInfoPtr_Peek_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100672213);
			SerStack.NativeMethodInfoPtr_PeekPeek_Internal_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100672214);
			SerStack.NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerStack>.NativeClassPtr, 100672215);
		}

		// Token: 0x06003B8B RID: 15243 RVA: 0x0011C710 File Offset: 0x0011A910
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 218819, RefRangeEnd = 218825, XrefRangeStart = 218816, XrefRangeEnd = 218819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerStack(string stackId)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerStack>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(stackId);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr__ctor_Internal_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B8C RID: 15244 RVA: 0x0011C75C File Offset: 0x0011A95C
		[CallerCount(22)]
		[CachedScanResults(RefRangeStart = 218834, RefRangeEnd = 218856, XrefRangeStart = 218825, XrefRangeEnd = 218834, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_Push_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003B8D RID: 15245 RVA: 0x0011C7A0 File Offset: 0x0011A9A0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 218857, RefRangeEnd = 218861, XrefRangeStart = 218856, XrefRangeEnd = 218857, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_Pop_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003B8E RID: 15246 RVA: 0x0011C7E0 File Offset: 0x0011A9E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 218861, XrefRangeEnd = 218865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void IncreaseCapacity()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003B8F RID: 15247 RVA: 0x0011C814 File Offset: 0x0011AA14
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 218865, RefRangeEnd = 218866, XrefRangeStart = 218865, XrefRangeEnd = 218865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_Peek_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003B90 RID: 15248 RVA: 0x0011C854 File Offset: 0x0011AA54
		[CallerCount(0)]
		public unsafe Object PeekPeek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_PeekPeek_Internal_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06003B91 RID: 15249 RVA: 0x0011C894 File Offset: 0x0011AA94
		[CallerCount(0)]
		public unsafe bool IsEmpty()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerStack.NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06003B92 RID: 15250 RVA: 0x000160F6 File Offset: 0x000142F6
		public SerStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06003B93 RID: 15251 RVA: 0x0011C8D0 File Offset: 0x0011AAD0
		// (set) Token: 0x06003B94 RID: 15252 RVA: 0x000160FF File Offset: 0x000142FF
		public unsafe Il2CppReferenceArray<Object> objects
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_objects);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_objects), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06003B95 RID: 15253 RVA: 0x0011C900 File Offset: 0x0011AB00
		// (set) Token: 0x06003B96 RID: 15254 RVA: 0x0001611E File Offset: 0x0001431E
		public unsafe string stackId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_stackId);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_stackId), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06003B97 RID: 15255 RVA: 0x0011C928 File Offset: 0x0011AB28
		// (set) Token: 0x06003B98 RID: 15256 RVA: 0x0001613D File Offset: 0x0001433D
		public unsafe int top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_top);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerStack.NativeFieldInfoPtr_top)) = value;
			}
		}

		// Token: 0x040031B4 RID: 12724
		private static readonly IntPtr NativeFieldInfoPtr_objects;

		// Token: 0x040031B5 RID: 12725
		private static readonly IntPtr NativeFieldInfoPtr_stackId;

		// Token: 0x040031B6 RID: 12726
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x040031B7 RID: 12727
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_String_0;

		// Token: 0x040031B8 RID: 12728
		private static readonly IntPtr NativeMethodInfoPtr_Push_Internal_Void_Object_0;

		// Token: 0x040031B9 RID: 12729
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Internal_Object_0;

		// Token: 0x040031BA RID: 12730
		private static readonly IntPtr NativeMethodInfoPtr_IncreaseCapacity_Internal_Void_0;

		// Token: 0x040031BB RID: 12731
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Internal_Object_0;

		// Token: 0x040031BC RID: 12732
		private static readonly IntPtr NativeMethodInfoPtr_PeekPeek_Internal_Object_0;

		// Token: 0x040031BD RID: 12733
		private static readonly IntPtr NativeMethodInfoPtr_IsEmpty_Internal_Boolean_0;
	}
}
