using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200001F RID: 31
	public class ByteStack : Object
	{
		// Token: 0x060001A6 RID: 422 RVA: 0x00019C08 File Offset: 0x00017E08
		// Note: this type is marked as 'beforefieldinit'.
		static ByteStack()
		{
			Il2CppClassPointerStore<ByteStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "ByteStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ByteStack>.NativeClassPtr);
			ByteStack.NativeFieldInfoPtr_stack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteStack>.NativeClassPtr, "stack");
			ByteStack.NativeFieldInfoPtr_growthRate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteStack>.NativeClassPtr, "growthRate");
			ByteStack.NativeFieldInfoPtr_top = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteStack>.NativeClassPtr, "top");
			ByteStack.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ByteStack>.NativeClassPtr, "size");
			ByteStack.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteStack>.NativeClassPtr, 100663476);
			ByteStack.NativeMethodInfoPtr_Push_Public_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteStack>.NativeClassPtr, 100663477);
			ByteStack.NativeMethodInfoPtr_Pop_Public_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ByteStack>.NativeClassPtr, 100663478);
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00019CC4 File Offset: 0x00017EC4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389683, RefRangeEnd = 389685, XrefRangeStart = 389680, XrefRangeEnd = 389683, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ByteStack(int growthRate)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ByteStack>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref growthRate;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteStack.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00019D0C File Offset: 0x00017F0C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 389689, RefRangeEnd = 389693, XrefRangeStart = 389685, XrefRangeEnd = 389689, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Push(byte data)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref data;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteStack.NativeMethodInfoPtr_Push_Public_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00019D4C File Offset: 0x00017F4C
		[CallerCount(0)]
		public unsafe byte Pop()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ByteStack.NativeMethodInfoPtr_Pop_Public_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00002BC8 File Offset: 0x00000DC8
		public ByteStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00019D88 File Offset: 0x00017F88
		// (set) Token: 0x060001AC RID: 428 RVA: 0x00002BD1 File Offset: 0x00000DD1
		public unsafe Il2CppStructArray<byte> stack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_stack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_stack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00019DB8 File Offset: 0x00017FB8
		// (set) Token: 0x060001AE RID: 430 RVA: 0x00002BF0 File Offset: 0x00000DF0
		public unsafe int growthRate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_growthRate);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_growthRate)) = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00019DE0 File Offset: 0x00017FE0
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x00002C0B File Offset: 0x00000E0B
		public unsafe int top
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_top);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_top)) = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00019E08 File Offset: 0x00018008
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x00002C26 File Offset: 0x00000E26
		public unsafe int size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ByteStack.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_stack;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeFieldInfoPtr_growthRate;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeFieldInfoPtr_top;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_Push_Public_Void_Byte_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr_Pop_Public_Byte_0;
	}
}
