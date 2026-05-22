using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngineInternal
{
	// Token: 0x02000006 RID: 6
	[StructLayout(2)]
	public struct MathfInternal
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00015828 File Offset: 0x00013A28
		// Note: this type is marked as 'beforefieldinit'.
		static MathfInternal()
		{
			Il2CppClassPointerStore<MathfInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngineInternal", "MathfInternal");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr);
			MathfInternal.NativeFieldInfoPtr_FloatMinNormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, "FloatMinNormal");
			MathfInternal.NativeFieldInfoPtr_FloatMinDenormal = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, "FloatMinDenormal");
			MathfInternal.NativeFieldInfoPtr_IsFlushToZeroEnabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, "IsFlushToZeroEnabled");
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002116 File Offset: 0x00000316
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MathfInternal>.NativeClassPtr, ref this));
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00015894 File Offset: 0x00013A94
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002128 File Offset: 0x00000328
		public unsafe static float FloatMinNormal
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MathfInternal.NativeFieldInfoPtr_FloatMinNormal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathfInternal.NativeFieldInfoPtr_FloatMinNormal, (void*)(&value));
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000158B0 File Offset: 0x00013AB0
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002136 File Offset: 0x00000336
		public unsafe static float FloatMinDenormal
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(MathfInternal.NativeFieldInfoPtr_FloatMinDenormal, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathfInternal.NativeFieldInfoPtr_FloatMinDenormal, (void*)(&value));
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x000158CC File Offset: 0x00013ACC
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002144 File Offset: 0x00000344
		public unsafe static bool IsFlushToZeroEnabled
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(MathfInternal.NativeFieldInfoPtr_IsFlushToZeroEnabled, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(MathfInternal.NativeFieldInfoPtr_IsFlushToZeroEnabled, (void*)(&value));
			}
		}

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeFieldInfoPtr_FloatMinNormal;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeFieldInfoPtr_FloatMinDenormal;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeFieldInfoPtr_IsFlushToZeroEnabled;
	}
}
