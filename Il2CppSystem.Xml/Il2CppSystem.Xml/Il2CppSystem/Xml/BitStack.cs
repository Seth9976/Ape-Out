using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml
{
	// Token: 0x0200001D RID: 29
	public class BitStack : Object
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00019780 File Offset: 0x00017980
		// Note: this type is marked as 'beforefieldinit'.
		static BitStack()
		{
			Il2CppClassPointerStore<BitStack>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml", "BitStack");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BitStack>.NativeClassPtr);
			BitStack.NativeFieldInfoPtr_bitStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitStack>.NativeClassPtr, "bitStack");
			BitStack.NativeFieldInfoPtr_stackPos = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitStack>.NativeClassPtr, "stackPos");
			BitStack.NativeFieldInfoPtr_curr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BitStack>.NativeClassPtr, "curr");
			BitStack.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStack>.NativeClassPtr, 100663467);
			BitStack.NativeMethodInfoPtr_PushBit_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStack>.NativeClassPtr, 100663468);
			BitStack.NativeMethodInfoPtr_PopBit_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStack>.NativeClassPtr, 100663469);
			BitStack.NativeMethodInfoPtr_PeekBit_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStack>.NativeClassPtr, 100663470);
			BitStack.NativeMethodInfoPtr_PushCurr_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStack>.NativeClassPtr, 100663471);
			BitStack.NativeMethodInfoPtr_PopCurr_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BitStack>.NativeClassPtr, 100663472);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00019864 File Offset: 0x00017A64
		[CallerCount(0)]
		public unsafe BitStack()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BitStack>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitStack.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018C RID: 396 RVA: 0x000198A0 File Offset: 0x00017AA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 389651, XrefRangeEnd = 389652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushBit(bool bit)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref bit;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitStack.NativeMethodInfoPtr_PushBit_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018D RID: 397 RVA: 0x000198E0 File Offset: 0x00017AE0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 389652, RefRangeEnd = 389654, XrefRangeStart = 389652, XrefRangeEnd = 389652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool PopBit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitStack.NativeMethodInfoPtr_PopBit_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0001991C File Offset: 0x00017B1C
		[CallerCount(0)]
		public unsafe bool PeekBit()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitStack.NativeMethodInfoPtr_PeekBit_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00019958 File Offset: 0x00017B58
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 389662, RefRangeEnd = 389666, XrefRangeStart = 389654, XrefRangeEnd = 389662, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void PushCurr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitStack.NativeMethodInfoPtr_PushCurr_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0001998C File Offset: 0x00017B8C
		[CallerCount(0)]
		public unsafe void PopCurr()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BitStack.NativeMethodInfoPtr_PopCurr_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00002B1B File Offset: 0x00000D1B
		public BitStack(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000192 RID: 402 RVA: 0x000199C0 File Offset: 0x00017BC0
		// (set) Token: 0x06000193 RID: 403 RVA: 0x00002B24 File Offset: 0x00000D24
		public unsafe Il2CppStructArray<uint> bitStack
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitStack.NativeFieldInfoPtr_bitStack);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<uint>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitStack.NativeFieldInfoPtr_bitStack), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000194 RID: 404 RVA: 0x000199F0 File Offset: 0x00017BF0
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00002B43 File Offset: 0x00000D43
		public unsafe int stackPos
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitStack.NativeFieldInfoPtr_stackPos);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitStack.NativeFieldInfoPtr_stackPos)) = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00019A18 File Offset: 0x00017C18
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00002B5E File Offset: 0x00000D5E
		public unsafe uint curr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitStack.NativeFieldInfoPtr_curr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BitStack.NativeFieldInfoPtr_curr)) = value;
			}
		}

		// Token: 0x040000F9 RID: 249
		private static readonly IntPtr NativeFieldInfoPtr_bitStack;

		// Token: 0x040000FA RID: 250
		private static readonly IntPtr NativeFieldInfoPtr_stackPos;

		// Token: 0x040000FB RID: 251
		private static readonly IntPtr NativeFieldInfoPtr_curr;

		// Token: 0x040000FC RID: 252
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040000FD RID: 253
		private static readonly IntPtr NativeMethodInfoPtr_PushBit_Public_Void_Boolean_0;

		// Token: 0x040000FE RID: 254
		private static readonly IntPtr NativeMethodInfoPtr_PopBit_Public_Boolean_0;

		// Token: 0x040000FF RID: 255
		private static readonly IntPtr NativeMethodInfoPtr_PeekBit_Public_Boolean_0;

		// Token: 0x04000100 RID: 256
		private static readonly IntPtr NativeMethodInfoPtr_PushCurr_Private_Void_0;

		// Token: 0x04000101 RID: 257
		private static readonly IntPtr NativeMethodInfoPtr_PopCurr_Private_Void_0;
	}
}
