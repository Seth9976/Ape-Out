using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem
{
	// Token: 0x0200008D RID: 141
	[Serializable]
	[StructLayout(2)]
	public struct ConsoleKeyInfo
	{
		// Token: 0x060008AE RID: 2222 RVA: 0x0004A62C File Offset: 0x0004882C
		// Note: this type is marked as 'beforefieldinit'.
		static ConsoleKeyInfo()
		{
			Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ConsoleKeyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr);
			ConsoleKeyInfo.NativeFieldInfoPtr__keyChar = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, "_keyChar");
			ConsoleKeyInfo.NativeFieldInfoPtr__key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, "_key");
			ConsoleKeyInfo.NativeFieldInfoPtr__mods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, "_mods");
			ConsoleKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Char_ConsoleKey_Boolean_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100664696);
			ConsoleKeyInfo.NativeMethodInfoPtr_get_KeyChar_Public_get_Char_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100664697);
			ConsoleKeyInfo.NativeMethodInfoPtr_get_Key_Public_get_ConsoleKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100664698);
			ConsoleKeyInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100664699);
			ConsoleKeyInfo.NativeMethodInfoPtr_Equals_Public_Boolean_ConsoleKeyInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100664700);
			ConsoleKeyInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, 100664701);
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0004A710 File Offset: 0x00048910
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 150217, RefRangeEnd = 150219, XrefRangeStart = 150217, XrefRangeEnd = 150217, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConsoleKeyInfo(char keyChar, ConsoleKey key, bool shift, bool alt, bool control)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyChar;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref key;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref shift;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref alt;
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref control;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr__ctor_Public_Void_Char_ConsoleKey_Boolean_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x0004A77C File Offset: 0x0004897C
		public unsafe char KeyChar
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_get_KeyChar_Public_get_Char_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x0004A7AC File Offset: 0x000489AC
		public unsafe ConsoleKey Key
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_get_Key_Public_get_ConsoleKey_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0004A7DC File Offset: 0x000489DC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 150219, XrefRangeEnd = 150221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0004A820 File Offset: 0x00048A20
		[CallerCount(0)]
		public unsafe bool Equals(ConsoleKeyInfo obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_Equals_Public_Boolean_ConsoleKeyInfo_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x0004A860 File Offset: 0x00048A60
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConsoleKeyInfo.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x000048F2 File Offset: 0x00002AF2
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ConsoleKeyInfo>.NativeClassPtr, ref this));
		}

		// Token: 0x0400070D RID: 1805
		private static readonly IntPtr NativeFieldInfoPtr__keyChar;

		// Token: 0x0400070E RID: 1806
		private static readonly IntPtr NativeFieldInfoPtr__key;

		// Token: 0x0400070F RID: 1807
		private static readonly IntPtr NativeFieldInfoPtr__mods;

		// Token: 0x04000710 RID: 1808
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Char_ConsoleKey_Boolean_Boolean_Boolean_0;

		// Token: 0x04000711 RID: 1809
		private static readonly IntPtr NativeMethodInfoPtr_get_KeyChar_Public_get_Char_0;

		// Token: 0x04000712 RID: 1810
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_get_ConsoleKey_0;

		// Token: 0x04000713 RID: 1811
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000714 RID: 1812
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Boolean_ConsoleKeyInfo_0;

		// Token: 0x04000715 RID: 1813
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000716 RID: 1814
		[FieldOffset(0)]
		public char _keyChar;

		// Token: 0x04000717 RID: 1815
		[FieldOffset(4)]
		public ConsoleKey _key;

		// Token: 0x04000718 RID: 1816
		[FieldOffset(8)]
		public ConsoleModifiers _mods;
	}
}
