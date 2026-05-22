using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Net.Sockets
{
	// Token: 0x02000146 RID: 326
	public class LingerOption : Object
	{
		// Token: 0x0600149A RID: 5274 RVA: 0x0005DA30 File Offset: 0x0005BC30
		// Note: this type is marked as 'beforefieldinit'.
		static LingerOption()
		{
			Il2CppClassPointerStore<LingerOption>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Net.Sockets", "LingerOption");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LingerOption>.NativeClassPtr);
			LingerOption.NativeFieldInfoPtr_enabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, "enabled");
			LingerOption.NativeFieldInfoPtr_lingerTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, "lingerTime");
			LingerOption.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, 100666225);
			LingerOption.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, 100666226);
			LingerOption.NativeMethodInfoPtr_set_LingerTime_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LingerOption>.NativeClassPtr, 100666227);
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x0005DAC4 File Offset: 0x0005BCC4
		[CallerCount(0)]
		public unsafe LingerOption(bool enable, int seconds)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LingerOption>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enable;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref seconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LingerOption.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170006A0 RID: 1696
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x0005DB1C File Offset: 0x0005BD1C
		public unsafe bool Enabled
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LingerOption.NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (set) Token: 0x0600149D RID: 5277 RVA: 0x0005DB5C File Offset: 0x0005BD5C
		public unsafe int LingerTime
		{
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(LingerOption.NativeMethodInfoPtr_set_LingerTime_Public_set_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x0000A6D8 File Offset: 0x000088D8
		public LingerOption(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x0005DB9C File Offset: 0x0005BD9C
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x0000A6E1 File Offset: 0x000088E1
		public unsafe bool enabled
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LingerOption.NativeFieldInfoPtr_enabled);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LingerOption.NativeFieldInfoPtr_enabled)) = value;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0005DBC4 File Offset: 0x0005BDC4
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0000A6FC File Offset: 0x000088FC
		public unsafe int lingerTime
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LingerOption.NativeFieldInfoPtr_lingerTime);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(LingerOption.NativeFieldInfoPtr_lingerTime)) = value;
			}
		}

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeFieldInfoPtr_enabled;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeFieldInfoPtr_lingerTime;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Int32_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr_set_Enabled_Public_set_Void_Boolean_0;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_set_LingerTime_Public_set_Void_Int32_0;
	}
}
