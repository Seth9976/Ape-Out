using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Globalization;

namespace UnityEngine
{
	// Token: 0x020000AB RID: 171
	[StructLayout(2)]
	public struct Vector2Int
	{
		// Token: 0x06001086 RID: 4230 RVA: 0x00044A5C File Offset: 0x00042C5C
		// Note: this type is marked as 'beforefieldinit'.
		static Vector2Int()
		{
			Il2CppClassPointerStore<Vector2Int>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Vector2Int");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr);
			Vector2Int.NativeFieldInfoPtr_m_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "m_X");
			Vector2Int.NativeFieldInfoPtr_m_Y = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "m_Y");
			Vector2Int.NativeFieldInfoPtr_s_Zero = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Zero");
			Vector2Int.NativeFieldInfoPtr_s_One = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_One");
			Vector2Int.NativeFieldInfoPtr_s_Up = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Up");
			Vector2Int.NativeFieldInfoPtr_s_Down = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Down");
			Vector2Int.NativeFieldInfoPtr_s_Left = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Left");
			Vector2Int.NativeFieldInfoPtr_s_Right = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, "s_Right");
			Vector2Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664642);
			Vector2Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664643);
			Vector2Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664644);
			Vector2Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664645);
			Vector2Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664646);
			Vector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664647);
			Vector2Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664648);
			Vector2Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2Int_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664649);
			Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664650);
			Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664651);
			Vector2Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664652);
			Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664653);
			Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664654);
			Vector2Int.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2Int_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, 100664655);
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001087 RID: 4231 RVA: 0x00044C44 File Offset: 0x00042E44
		// (set) Token: 0x06001088 RID: 4232 RVA: 0x00044C74 File Offset: 0x00042E74
		public unsafe int x
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_x_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001089 RID: 4233 RVA: 0x00044CA8 File Offset: 0x00042EA8
		// (set) Token: 0x0600108A RID: 4234 RVA: 0x00044CD8 File Offset: 0x00042ED8
		public unsafe int y
		{
			[CallerCount(0)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_y_Public_get_Int32_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00044D0C File Offset: 0x00042F0C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 76853, RefRangeEnd = 76855, XrefRangeStart = 76853, XrefRangeEnd = 76855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Vector2Int(int x, int y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00044D4C File Offset: 0x00042F4C
		[CallerCount(0)]
		public unsafe static implicit operator Vector2(Vector2Int v)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref v;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00044D8C File Offset: 0x00042F8C
		[CallerCount(0)]
		public unsafe static bool operator ==(Vector2Int lhs, Vector2Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2Int_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00044DD8 File Offset: 0x00042FD8
		[CallerCount(0)]
		public unsafe static bool operator !=(Vector2Int lhs, Vector2Int rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2Int_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00044E24 File Offset: 0x00043024
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493317, XrefRangeEnd = 493319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00044E68 File Offset: 0x00043068
		[CallerCount(0)]
		public unsafe bool Equals(Vector2Int other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00044EA8 File Offset: 0x000430A8
		[CallerCount(0)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00044ED8 File Offset: 0x000430D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 493329, RefRangeEnd = 493330, XrefRangeStart = 493319, XrefRangeEnd = 493329, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_String_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x00044F04 File Offset: 0x00043104
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 493349, RefRangeEnd = 493350, XrefRangeStart = 493330, XrefRangeEnd = 493349, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ToString(string format, IFormatProvider formatProvider)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(format);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(formatProvider);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001094 RID: 4244 RVA: 0x00044F54 File Offset: 0x00043154
		public unsafe static Vector2Int zero
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 493350, XrefRangeEnd = 493352, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Vector2Int.NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2Int_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x0000A0FB File Offset: 0x000082FB
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Vector2Int>.NativeClassPtr, ref this));
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001096 RID: 4246 RVA: 0x00044F84 File Offset: 0x00043184
		// (set) Token: 0x06001097 RID: 4247 RVA: 0x0000A10D File Offset: 0x0000830D
		public unsafe static Vector2Int s_Zero
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Zero, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Zero, (void*)(&value));
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001098 RID: 4248 RVA: 0x00044FA0 File Offset: 0x000431A0
		// (set) Token: 0x06001099 RID: 4249 RVA: 0x0000A11B File Offset: 0x0000831B
		public unsafe static Vector2Int s_One
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_One, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_One, (void*)(&value));
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x00044FBC File Offset: 0x000431BC
		// (set) Token: 0x0600109B RID: 4251 RVA: 0x0000A129 File Offset: 0x00008329
		public unsafe static Vector2Int s_Up
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Up, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Up, (void*)(&value));
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x0600109C RID: 4252 RVA: 0x00044FD8 File Offset: 0x000431D8
		// (set) Token: 0x0600109D RID: 4253 RVA: 0x0000A137 File Offset: 0x00008337
		public unsafe static Vector2Int s_Down
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Down, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Down, (void*)(&value));
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x0600109E RID: 4254 RVA: 0x00044FF4 File Offset: 0x000431F4
		// (set) Token: 0x0600109F RID: 4255 RVA: 0x0000A145 File Offset: 0x00008345
		public unsafe static Vector2Int s_Left
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Left, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Left, (void*)(&value));
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x060010A0 RID: 4256 RVA: 0x00045010 File Offset: 0x00043210
		// (set) Token: 0x060010A1 RID: 4257 RVA: 0x0000A153 File Offset: 0x00008353
		public unsafe static Vector2Int s_Right
		{
			get
			{
				Vector2Int vector2Int;
				IL2CPP.il2cpp_field_static_get_value(Vector2Int.NativeFieldInfoPtr_s_Right, (void*)(&vector2Int));
				return vector2Int;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Vector2Int.NativeFieldInfoPtr_s_Right, (void*)(&value));
			}
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x0000A161 File Offset: 0x00008361
		public void Set(int x, int y)
		{
			this.m_X = x;
			this.m_Y = y;
		}

		// Token: 0x1700037B RID: 891
		public int this[int index]
		{
			get
			{
				int num;
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException(String.Format("Invalid Vector2Int index addressed: {0}!", index));
					}
					num = this.y;
				}
				else
				{
					num = this.x;
				}
				return num;
			}
			set
			{
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException(String.Format("Invalid Vector2Int index addressed: {0}!", index));
					}
					this.y = value;
				}
				else
				{
					this.x = value;
				}
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x060010A5 RID: 4261 RVA: 0x000450BC File Offset: 0x000432BC
		public float magnitude
		{
			get
			{
				return Mathf.Sqrt((float)(this.x * this.x + this.y * this.y));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x060010A6 RID: 4262 RVA: 0x000450F0 File Offset: 0x000432F0
		public int sqrMagnitude
		{
			get
			{
				return this.x * this.x + this.y * this.y;
			}
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00045120 File Offset: 0x00043320
		public static float Distance(Vector2Int a, Vector2Int b)
		{
			float num = (float)(a.x - b.x);
			float num2 = (float)(a.y - b.y);
			return (float)Math.Sqrt((double)(num * num + num2 * num2));
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00045164 File Offset: 0x00043364
		public static Vector2Int Min(Vector2Int lhs, Vector2Int rhs)
		{
			return new Vector2Int(Mathf.Min(lhs.x, rhs.x), Mathf.Min(lhs.y, rhs.y));
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x000451A4 File Offset: 0x000433A4
		public static Vector2Int Max(Vector2Int lhs, Vector2Int rhs)
		{
			return new Vector2Int(Mathf.Max(lhs.x, rhs.x), Mathf.Max(lhs.y, rhs.y));
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x000451E4 File Offset: 0x000433E4
		public static Vector2Int Scale(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x * b.x, a.y * b.y);
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x0000A172 File Offset: 0x00008372
		public void Scale(Vector2Int scale)
		{
			this.x *= scale.x;
			this.y *= scale.y;
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x0004521C File Offset: 0x0004341C
		public void Clamp(Vector2Int min, Vector2Int max)
		{
			this.x = Math.Max(min.x, this.x);
			this.x = Math.Min(max.x, this.x);
			this.y = Math.Max(min.y, this.y);
			this.y = Math.Min(max.y, this.y);
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00045290 File Offset: 0x00043490
		public static explicit operator Vector3Int(Vector2Int v)
		{
			return new Vector3Int(v.x, v.y, 0);
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x000452B8 File Offset: 0x000434B8
		public static Vector2Int FloorToInt(Vector2 v)
		{
			return new Vector2Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y));
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x000452E8 File Offset: 0x000434E8
		public static Vector2Int CeilToInt(Vector2 v)
		{
			return new Vector2Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y));
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00045318 File Offset: 0x00043518
		public static Vector2Int RoundToInt(Vector2 v)
		{
			return new Vector2Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y));
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00045348 File Offset: 0x00043548
		public static Vector2Int operator -(Vector2Int v)
		{
			return new Vector2Int(-v.x, -v.y);
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00045370 File Offset: 0x00043570
		public static Vector2Int operator +(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x + b.x, a.y + b.y);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x000453A8 File Offset: 0x000435A8
		public static Vector2Int operator -(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x - b.x, a.y - b.y);
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x000453E0 File Offset: 0x000435E0
		public static Vector2Int operator *(Vector2Int a, Vector2Int b)
		{
			return new Vector2Int(a.x * b.x, a.y * b.y);
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00045418 File Offset: 0x00043618
		public static Vector2Int operator *(int a, Vector2Int b)
		{
			return new Vector2Int(a * b.x, a * b.y);
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00045444 File Offset: 0x00043644
		public static Vector2Int operator *(Vector2Int a, int b)
		{
			return new Vector2Int(a.x * b, a.y * b);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00045470 File Offset: 0x00043670
		public static Vector2Int operator /(Vector2Int a, int b)
		{
			return new Vector2Int(a.x / b, a.y / b);
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x0004549C File Offset: 0x0004369C
		public string ToString(string format)
		{
			return this.ToString(format, CultureInfo.InvariantCulture.NumberFormat);
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x000454C0 File Offset: 0x000436C0
		public static Vector2Int one
		{
			get
			{
				return Vector2Int.s_One;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x060010BA RID: 4282 RVA: 0x000454D8 File Offset: 0x000436D8
		public static Vector2Int up
		{
			get
			{
				return Vector2Int.s_Up;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x060010BB RID: 4283 RVA: 0x000454F0 File Offset: 0x000436F0
		public static Vector2Int down
		{
			get
			{
				return Vector2Int.s_Down;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x060010BC RID: 4284 RVA: 0x00045508 File Offset: 0x00043708
		public static Vector2Int left
		{
			get
			{
				return Vector2Int.s_Left;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x060010BD RID: 4285 RVA: 0x00045520 File Offset: 0x00043720
		public static Vector2Int right
		{
			get
			{
				return Vector2Int.s_Right;
			}
		}

		// Token: 0x04000DAF RID: 3503
		private static readonly IntPtr NativeFieldInfoPtr_m_X;

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeFieldInfoPtr_m_Y;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeFieldInfoPtr_s_Zero;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeFieldInfoPtr_s_One;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeFieldInfoPtr_s_Up;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeFieldInfoPtr_s_Down;

		// Token: 0x04000DB5 RID: 3509
		private static readonly IntPtr NativeFieldInfoPtr_s_Left;

		// Token: 0x04000DB6 RID: 3510
		private static readonly IntPtr NativeFieldInfoPtr_s_Right;

		// Token: 0x04000DB7 RID: 3511
		private static readonly IntPtr NativeMethodInfoPtr_get_x_Public_get_Int32_0;

		// Token: 0x04000DB8 RID: 3512
		private static readonly IntPtr NativeMethodInfoPtr_set_x_Public_set_Void_Int32_0;

		// Token: 0x04000DB9 RID: 3513
		private static readonly IntPtr NativeMethodInfoPtr_get_y_Public_get_Int32_0;

		// Token: 0x04000DBA RID: 3514
		private static readonly IntPtr NativeMethodInfoPtr_set_y_Public_set_Void_Int32_0;

		// Token: 0x04000DBB RID: 3515
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Int32_0;

		// Token: 0x04000DBC RID: 3516
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_Vector2_Vector2Int_0;

		// Token: 0x04000DBD RID: 3517
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_Vector2Int_Vector2Int_0;

		// Token: 0x04000DBE RID: 3518
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_Vector2Int_Vector2Int_0;

		// Token: 0x04000DBF RID: 3519
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000DC0 RID: 3520
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Vector2Int_0;

		// Token: 0x04000DC1 RID: 3521
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000DC2 RID: 3522
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000DC3 RID: 3523
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_Final_New_String_String_IFormatProvider_0;

		// Token: 0x04000DC4 RID: 3524
		private static readonly IntPtr NativeMethodInfoPtr_get_zero_Public_Static_get_Vector2Int_0;

		// Token: 0x04000DC5 RID: 3525
		[FieldOffset(0)]
		public int m_X;

		// Token: 0x04000DC6 RID: 3526
		[FieldOffset(4)]
		public int m_Y;
	}
}
