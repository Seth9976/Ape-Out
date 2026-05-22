using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace Il2CppTMPro
{
	// Token: 0x02000063 RID: 99
	public static class TMP_Math : global::Il2CppSystem.Object
	{
		// Token: 0x06000C38 RID: 3128 RVA: 0x00033D40 File Offset: 0x00031F40
		// Note: this type is marked as 'beforefieldinit'.
		static TMP_Math()
		{
			Il2CppClassPointerStore<TMP_Math>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.TextMeshPro.dll", "TMPro", "TMP_Math");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr);
			TMP_Math.NativeFieldInfoPtr_FLOAT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "FLOAT_MAX");
			TMP_Math.NativeFieldInfoPtr_FLOAT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "FLOAT_MIN");
			TMP_Math.NativeFieldInfoPtr_INT_MAX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "INT_MAX");
			TMP_Math.NativeFieldInfoPtr_INT_MIN = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "INT_MIN");
			TMP_Math.NativeFieldInfoPtr_FLOAT_UNSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "FLOAT_UNSET");
			TMP_Math.NativeFieldInfoPtr_INT_UNSET = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "INT_UNSET");
			TMP_Math.NativeFieldInfoPtr_MAX_16BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "MAX_16BIT");
			TMP_Math.NativeFieldInfoPtr_MIN_16BIT = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, "MIN_16BIT");
			TMP_Math.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, 100664701);
			TMP_Math.NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TMP_Math>.NativeClassPtr, 100664702);
		}

		// Token: 0x06000C39 RID: 3129 RVA: 0x00033E38 File Offset: 0x00032038
		[CallerCount(0)]
		public unsafe static bool Approximately(float a, float b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Math.NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x00033E84 File Offset: 0x00032084
		[CallerCount(0)]
		public unsafe static int Mod(int a, int b)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref a;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref b;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TMP_Math.NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C3B RID: 3131 RVA: 0x00007A54 File Offset: 0x00005C54
		public TMP_Math(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x00033ED0 File Offset: 0x000320D0
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x00007A5D File Offset: 0x00005C5D
		public unsafe static float FLOAT_MAX
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_FLOAT_MAX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_FLOAT_MAX, (void*)(&value));
			}
		}

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06000C3E RID: 3134 RVA: 0x00033EEC File Offset: 0x000320EC
		// (set) Token: 0x06000C3F RID: 3135 RVA: 0x00007A6B File Offset: 0x00005C6B
		public unsafe static float FLOAT_MIN
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_FLOAT_MIN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_FLOAT_MIN, (void*)(&value));
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00033F08 File Offset: 0x00032108
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x00007A79 File Offset: 0x00005C79
		public unsafe static int INT_MAX
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_INT_MAX, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_INT_MAX, (void*)(&value));
			}
		}

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x00033F24 File Offset: 0x00032124
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x00007A87 File Offset: 0x00005C87
		public unsafe static int INT_MIN
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_INT_MIN, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_INT_MIN, (void*)(&value));
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00033F40 File Offset: 0x00032140
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00007A95 File Offset: 0x00005C95
		public unsafe static float FLOAT_UNSET
		{
			get
			{
				float num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_FLOAT_UNSET, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_FLOAT_UNSET, (void*)(&value));
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x00033F5C File Offset: 0x0003215C
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x00007AA3 File Offset: 0x00005CA3
		public unsafe static int INT_UNSET
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_INT_UNSET, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_INT_UNSET, (void*)(&value));
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000C48 RID: 3144 RVA: 0x00033F78 File Offset: 0x00032178
		// (set) Token: 0x06000C49 RID: 3145 RVA: 0x00007AB1 File Offset: 0x00005CB1
		public unsafe static Vector2 MAX_16BIT
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_MAX_16BIT, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_MAX_16BIT, (void*)(&value));
			}
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000C4A RID: 3146 RVA: 0x00033F94 File Offset: 0x00032194
		// (set) Token: 0x06000C4B RID: 3147 RVA: 0x00007ABF File Offset: 0x00005CBF
		public unsafe static Vector2 MIN_16BIT
		{
			get
			{
				Vector2 vector;
				IL2CPP.il2cpp_field_static_get_value(TMP_Math.NativeFieldInfoPtr_MIN_16BIT, (void*)(&vector));
				return vector;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TMP_Math.NativeFieldInfoPtr_MIN_16BIT, (void*)(&value));
			}
		}

		// Token: 0x040009C1 RID: 2497
		private static readonly IntPtr NativeFieldInfoPtr_FLOAT_MAX;

		// Token: 0x040009C2 RID: 2498
		private static readonly IntPtr NativeFieldInfoPtr_FLOAT_MIN;

		// Token: 0x040009C3 RID: 2499
		private static readonly IntPtr NativeFieldInfoPtr_INT_MAX;

		// Token: 0x040009C4 RID: 2500
		private static readonly IntPtr NativeFieldInfoPtr_INT_MIN;

		// Token: 0x040009C5 RID: 2501
		private static readonly IntPtr NativeFieldInfoPtr_FLOAT_UNSET;

		// Token: 0x040009C6 RID: 2502
		private static readonly IntPtr NativeFieldInfoPtr_INT_UNSET;

		// Token: 0x040009C7 RID: 2503
		private static readonly IntPtr NativeFieldInfoPtr_MAX_16BIT;

		// Token: 0x040009C8 RID: 2504
		private static readonly IntPtr NativeFieldInfoPtr_MIN_16BIT;

		// Token: 0x040009C9 RID: 2505
		private static readonly IntPtr NativeMethodInfoPtr_Approximately_Public_Static_Boolean_Single_Single_0;

		// Token: 0x040009CA RID: 2506
		private static readonly IntPtr NativeMethodInfoPtr_Mod_Public_Static_Int32_Int32_Int32_0;
	}
}
